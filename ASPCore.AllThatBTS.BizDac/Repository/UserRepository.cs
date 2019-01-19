using ASPCore.AllThatBTS.Common;
using ASPCore.AllThatBTS.Model;
using Microsoft.Extensions.Options;
using NPoco;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Repository
{
    public class UserRepository : IUser
    {
        private string connectionString;

        public UserRepository()
        {
            var appSetting = new AppConfiguration();
            connectionString = appSetting.SqlDataConnection;
        }

        public IDatabase Connection
        {
            get
            {
                return new Database(connectionString,
                                DatabaseType.MySQL,
                                MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            }
        }

        public void DeleteUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void InsertUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public List<User> SelectAllUsers()
        {
            return Connection.Fetch<User>();
        }

        public User SelectUserByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
