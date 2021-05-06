using System;
using Ringen.Schnittstellen.RDB.DependencyInjection;
using Ringen.Schnittstellen.RDB.Models;
using Ringen.Schnittstellen.Contracts.Factories;
using Ringen.Schnittstellen.Contracts.Models;

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
