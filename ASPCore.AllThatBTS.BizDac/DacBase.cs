using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using ASPCore.AllThatBTS.Model;

namespace ASPCore.AllThatBTS.BizDac
{
    public class DacBase
    {
        private IOptions<ConfigurationManager> _configurationService;
        protected readonly IDatabase _db;

        public DacBase(IOptions<ConfigurationManager> _configurationService)
        {
            this._configurationService = _configurationService;
            _db = new NPoco.Database(_configurationService.Value.ConnectionString,
                                     DatabaseType.MySQL,
                                     MySql.Data.MySqlClient.MySqlClientFactory.Instance);
        }
    }

}
