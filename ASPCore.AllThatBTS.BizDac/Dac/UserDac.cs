using ASPCore.AllThatBTS.Model;
using NPoco;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.BizDac
{
    public class UserDac : DacBase
    {
        private static readonly IDatabase _db =
            new NPoco.Database(@"Server=127.0.0.1;Port=3306;Database=btsdb;Uid=admin;Pwd=0(@apadm@);", DatabaseType.MySQL, MySql.Data.MySqlClient.MySqlClientFactory.Instance);

        public UserDac() : base() { }

        public List<User> SelectAllUsers()
        {
            return _db.Fetch<User>();
        }

    }
}
