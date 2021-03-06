using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ringen.Schnittstellen.Contracts.Exceptions;
using Ringen.Schnittstellen.Contracts.Models;
using Ringen.Schnittstellen.Contracts.Services;
using Ringen.Schnittstellen.RDB.ApiModels.Post;
using Ringen.Schnittstellen.RDB.Helpers;
using Ringen.Schnittstellen.RDB.Mapper;

namespace Ringen.Schnittstellen.RDB.Services
{
    internal class ApiErgebnisdienst : IApiErgebnisdienst
    {
        private readonly RdbService _rdbService;
        private readonly MannschaftskampfPostMapper _mapper;
        
        public ApiErgebnisdienst(RdbService rdbService, MannschaftskampfPostMapper mapper)
        {
            _rdbService = rdbService;
            _mapper = mapper;
        }

        public async Task Uebermittle_Ergebnis_Async(Mannschaftskampf mannschaftskampf, List<Einzelkampf> einzelkaempfe)
        {
            CompetitionPostApiModel apiModel = _mapper.Map(mannschaftskampf, einzelkaempfe);

            List<ValidationResult> validationResults=new List<ValidationResult>();
            bool isValid = ValidationHelper.IsValidate(apiModel, fehlerListe => validationResults = fehlerListe);
            if (!isValid)
            {
                List<KeyValuePair<string, string>> validierungsFehler = new List<KeyValuePair<string, string>>();
                foreach (var validationResult in validationResults)
                {
                    validierungsFehler.AddRange(validationResult.MemberNames.Select(member =>
                        new KeyValuePair<string, string>(member, validationResult.ErrorMessage)));
                }

                throw new ApiValidierungException(validierungsFehler);
            }

            //TODO: Impl. finalisieren
            var httpResponse = await _rdbService.Sende_Ergebnis_Async(apiModel: apiModel);
        }
    }
}
