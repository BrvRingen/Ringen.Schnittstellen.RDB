using System;
using Ringen.Schnittstellen.Contracts.Models;
using Ringen.Schnittstellen.Contracts.Models.Enums;
using Ringen.Schnittstellen.RDB.ApiModels;

namespace Ringen.Schnittstellen.RDB.Mapper
{
    internal class RingerMapper
    {
        public Ringer Map(WrestlerApiModel apiModel)
        {
            Ringer result = new Ringer
            {
                Vorname = apiModel.Givenname,
                Nachname = apiModel.Name,
                Status = apiModel.AuthRating,
                Startausweisnummer = apiModel.PassCode,
                Lizenznummer = apiModel.LicenceCode?.ToString(),
                Geburtsdatum = DateTime.Parse(apiModel.Birthday),
                Vereinsnummer = apiModel.ClubCode,
            };

            switch (apiModel.Gender.ToUpper())
            {
                case "M":
                    result.Geschlecht = Geschlecht.Maennlich;
                    break;

                case "W":
                    result.Geschlecht = Geschlecht.Weiblich;
                    break;

                default:
                    throw new ArgumentException($"Geschlecht {apiModel.Gender} konnte nicht ermittelt werden");
            }
            
            return result;
        }
    }
}
