using System.Collections.Generic;
using Ringen.Schnittstellen.Contracts.Models.Enums;

namespace Ringen.Schnittstellen.RDB.Konvertierer
{
    internal class HeimGastKonvertierer : KonvertiererBase<HeimGast>
    {
        protected override Dictionary<string, HeimGast> MappingDictionary { get; } = new Dictionary<string, HeimGast>()
        {
            {"R", HeimGast.Heim },
            {"B", HeimGast.Gast },
        };
    }
}
