using Ringen.Schnittstellen.Contracts.Models;
using Ringen.Schnittstellen.RDB.ApiModels;

namespace Ringen.Schnittstellen.RDB.Mapper
{
    internal class SaisonMapper
    {
        public Saison Map(SaisonApiModel apiModel)
        {
            var result = new Saison
            {
                SaisonId = apiModel.SaisonId,
                Bezeichnung = apiModel.Description,
                Ligenleiter = apiModel.ControllerName
            };

            return result;
        }
    }
}
