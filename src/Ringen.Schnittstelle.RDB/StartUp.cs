using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ringen.Schnittstelle.RDB.DependencyInjection;

namespace Ringen.Schnittstellen.RDB
{
    public class StartUp
    {
        public static void Init(Models.RdbSystemSettings settings)
        {
            RDBNinjectKernel.CreateKernel();
        }
    }
}
