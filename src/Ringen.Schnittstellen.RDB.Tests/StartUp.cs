using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using NUnit.Framework;
using Ringen.Schnittstellen.RDB.Models;

namespace Ringen.Schnittstellen.RDB.Tests
{
    [SetUpFixture]
    class StartUp
    {
        [OneTimeSetUp]
        public void Init()
        {
            var settings = new RdbSystemSettings("http://test.rdb.ringen-nrw.de", new NetworkCredential("",""));
            RDB.StartUp.Init(settings);
        }
    }
}
