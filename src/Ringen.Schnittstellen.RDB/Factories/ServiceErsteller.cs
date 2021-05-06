using Ringen.Schnittstellen.RDB.DependencyInjection;
using Ringen.Schnittstellen.Contracts.Factories;

namespace Ringen.Schnittstellen.RDB.Factories
{
    public class ServiceErsteller : IServiceErsteller
    {
        public T GetService<T>()
        {
            return RDBNinjectKernel.GetService<T>();
        }
    }
}
