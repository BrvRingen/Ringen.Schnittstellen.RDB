using System.Collections.Generic;
using System.Linq;
using Ringen.Schnittstellen.Contracts.Models;
using Ringen.Schnittstellen.RDB.ApiModels;

namespace Ringen.Schnittstellen.RDB.Mapper
{
    internal class LeistungsklasseMapper
    {
        public Leistungsklasse Map(SystemApiModel apiModel)
        {
            var result = new Leistungsklasse
            {
                SystemId = apiModel.SystemId,
                Bezeichnung = apiModel.Display
            };

            return result;
        }

        public List<Leistungsklasse> Map(IEnumerable<SystemApiModel> apiModelListe)
        {
            return apiModelListe.Select(apiModel => Map(apiModel)).ToList();
        }
    }
}
