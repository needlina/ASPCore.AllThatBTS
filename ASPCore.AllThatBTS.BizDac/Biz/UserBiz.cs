using ASPCore.AllThatBTS.Model;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.BizDac
{
    public class UserBiz
    {
        public UserDac userDac = null;

        public UserBiz(IOptions<ConfigurationManager> settings)
        {
            userDac = new UserDac(settings);
        }

        public List<User> GetAllUser()
        {
            return userDac.SelectAllUsers();
        }
    }
}
