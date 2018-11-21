using ASPCore.AllThatBTS.Model;
using Microsoft.Extensions.Options;
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
        private static IOptions<ConfigurationManager> _ConfigurationManager;
        private readonly IDatabase db;

        public UserDac() : base(_ConfigurationManager)
        {
            db = base._db;
        }

        public List<User> SelectAllUsers()
        {
            return _db.Fetch<User>();
        }

    }
}
