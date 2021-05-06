using Ninject.Modules;
using Ringen.Schnittstellen.Contracts.Services;
using Ringen.Schnittstellen.RDB.Factories;
using Ringen.Schnittstellen.RDB.Konvertierer;
using Ringen.Schnittstellen.RDB.Mapper;
using Ringen.Schnittstellen.RDB.Services;

namespace Ringen.Schnittstellen.RDB.DependencyInjection
{
    internal class RDBDiModule : NinjectModule
    {
        public override void Load()
        {
            Bind<RdbService>().ToProvider<RdbServiceProvider>();

            Bind<IApiMannschaftskaempfe>().To<ApiMannschaftskaempfe>().InSingletonScope();
            Bind<IApiSaisonInformationen>().To<ApiSaisonInformationen>().InSingletonScope();
            Bind<IApiErgebnisdienst>().To<ApiErgebnisdienst>().InSingletonScope();
            Bind<IApiStammdaten>().To<ApiStammdaten>().InSingletonScope();

            Bind<GriffbewertungspunktKonvertierer>().ToSelf().InSingletonScope();
            Bind<GriffbewertungsTypKonvertierer>().ToSelf().InSingletonScope();
            Bind<HeimGastKonvertierer>().ToSelf().InSingletonScope();
            Bind<SiegartKonvertierer>().ToSelf().InSingletonScope();
            Bind<StilartKonvertierer>().ToSelf().InSingletonScope();

            Bind<MannschaftskampfPostMapper>().ToSelf().InSingletonScope();
            Bind<EinzelkampfMapper>().ToSelf().InSingletonScope();
        }
    }
}
