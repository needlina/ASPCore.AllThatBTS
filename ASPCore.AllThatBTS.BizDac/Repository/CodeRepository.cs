using ASPCore.AllThatBTS.Common;
using ASPCore.AllThatBTS.Model;
using ASPCore.AllThatBTS.Repository.Interface;
using NPoco;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Repository
{
    public class CodeRepository : ICode
    {
        private string connectionString;

        public CodeRepository()
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

        public List<Code> SelectAllCode()
        {
            return Connection.Fetch<Code>();
        }

        public List<Code> SelectAllCodeByTableName(string tableName)
        {
            return Connection.Fetch<Code>(string.Format("SELECT * FROM TB_CODE WHERE TABLE_NAME = '{0}'", tableName));
        }
    }
}
