using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ASPCore.AllThatBTS.Common
{
    public class AppConfiguration
    {
        public string SqlDataConnection { get; }

        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            var appSetting = root.GetSection("ConfigurationManager");
            SqlDataConnection = appSetting["ConnectionString"];
        }
    }
}
