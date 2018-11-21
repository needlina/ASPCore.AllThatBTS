using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using ASPCore.AllThatBTS.Model;
using Microsoft.Extensions.Configuration;

namespace ASPCore.AllThatBTS.BizDac
{
    public class DacBase
    {
        private readonly IConfiguration config;
        protected readonly IDatabase db;
        public DacBase(IConfiguration config)
        {
            this.config = config;
            db = new NPoco.Database(config.GetConnectionString("Dev"),
                                     DatabaseType.MySQL,
                                     MySql.Data.MySqlClient.MySqlClientFactory.Instance);
        }        
    }
}
