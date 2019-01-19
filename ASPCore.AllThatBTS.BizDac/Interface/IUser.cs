using ASPCore.AllThatBTS.Model;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Repository
{
    interface IUser
    {
        List<User> SelectAllUsers();
        User SelectUserByID(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
