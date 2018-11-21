using ASPCore.AllThatBTS.Model;
using Microsoft.Extensions.Options;
using NPoco;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.BizDac
{
    public class UserDac
    {
        protected readonly IDatabase db;

        public UserDac(IOptions<ConfigurationManager> settings)
        {
            this.db = new Database(settings.Value.ConnectionString,
                                     DatabaseType.MySQL,
                                     MySql.Data.MySqlClient.MySqlClientFactory.Instance);
        }

        public List<User> SelectAllUsers()
        {
            return db.Fetch<User>();
        }

    }
}
