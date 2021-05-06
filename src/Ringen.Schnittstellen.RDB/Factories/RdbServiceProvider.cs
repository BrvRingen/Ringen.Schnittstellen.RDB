using System.Net;
using Http.Library.Models;
using Http.Library.Services;
using Ninject.Activation;
using Ringen.Schnittstellen.RDB.Models;
using Ringen.Schnittstellen.RDB.Services;

namespace Ringen.Schnittstellen.RDB.Factories
{
    internal class RdbServiceProvider : Provider<RdbService>
    {
        private const string Schnittstelle = "RDB";

        private static RdbSystemSettings _settings;
        
        public static void Init(RdbSystemSettings settings)
        {
            _settings = settings;
        }

        protected override RdbService CreateInstance(IContext context)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;

            HttpServiceSettings httpServiceSettings = new HttpServiceSettings(_settings.Credentials)
            {
                Authorization = RequestAuthorization.Basic
            };
            IHttpService httpService = new HttpService($"{Schnittstelle}", httpServiceSettings);

            RdbService service = new RdbService(httpService, _settings);

            return service;
        }
    }
}
