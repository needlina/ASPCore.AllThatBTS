using ASPCore.AllThatBTS.Model;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.BizDac
{
    public class UserBiz
    {
        public UserDac userDac = new UserDac();

        public List<User> GetAllUser()
        {
            return userDac.SelectAllUsers();
        }
    }
}
