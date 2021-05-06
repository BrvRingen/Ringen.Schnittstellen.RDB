using Ringen.Schnittstellen.RDB.DependencyInjection;
using Ringen.Schnittstellen.RDB.Factories;
using Ringen.Schnittstellen.RDB.Models;

namespace Ringen.Schnittstellen.RDB
{
    public class StartUp
    {
        public static void Init(RdbSystemSettings settings)
        {
            RdbServiceProvider.Init(settings);
            RDBNinjectKernel.CreateKernel();
        }
    }
}
