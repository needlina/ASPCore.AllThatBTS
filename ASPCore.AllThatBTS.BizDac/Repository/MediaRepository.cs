using ASPCore.AllThatBTS.Common;
using ASPCore.AllThatBTS.Model;
using NPoco;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Repository
{
    public class MediaRepository : IMedia
    {
        private string connectionString;

        public MediaRepository()
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

        public List<Media> SelectMediaByType(string mediaType, int PageNo = 0, int PageSize = 15)
        {
            if (mediaType == "A")
            {
                //return Connection.Fetch<Media>("SELECT * FROM TB_MEDIA");
                return Connection.SkipTake<Media>(PageNo, PageSize, "SELECT * FROM TB_MEDIA");
            }
            else
            {
                return Connection.SkipTake<Media>(PageNo, PageSize, string.Format("SELECT * FROM TB_MEDIA WHERE MEDIA_TYPE = '{0}'", mediaType));
            }
        }

        public List<Media> SelectMediaBySearch(string mediaType, string searchString, int PageNo = 0, int PageSize = 15)
        {
            // ALL : 전체
            if(mediaType == "A")
            {
                return Connection.SkipTake<Media>(PageNo, PageSize, string.Format("SELECT * FROM TB_MEDIA " +
                                            "WHERE SUBJECT LIKE '%{0}'%", searchString));
            }
            else
            {
                return Connection.SkipTake<Media>(PageNo, PageSize, string.Format("SELECT * FROM TB_MEDIA " +
                                            "WHERE MEDIA_TYPE = '{0}'" +
                                            "  AND SUBJECT LIKE '%{1}%'", mediaType, searchString));
            }
        }

        public Page<Media> SelectMediaByTypeWithPage(string mediaType, int PageNo = 1, int PageSize = 15)
        {
            if (mediaType == "A")
            {
                //return Connection.Fetch<Media>("SELECT * FROM TB_MEDIA");
                return Connection.Page<Media>(PageNo, PageSize, "SELECT * FROM TB_MEDIA");
            }
            else
            {
                return Connection.Page<Media>(PageNo, PageSize, string.Format("SELECT * FROM TB_MEDIA WHERE MEDIA_TYPE = '{0}'", mediaType));
            }
        }

        public Page<Media> SelectMediaBySearchWithPage(string mediaType, string searchString, int PageNo = 1, int PageSize = 15)
        {
            // ALL : 전체
            if (mediaType == "A")
            {
                return Connection.Page<Media>(PageNo, PageSize, string.Format("SELECT * FROM TB_MEDIA " +
                                            "WHERE SUBJECT LIKE '%{0}'%", searchString));
            }
            else
            {
                return Connection.Page<Media>(PageNo, PageSize, string.Format("SELECT * FROM TB_MEDIA " +
                                            "WHERE MEDIA_TYPE = '{0}'" +
                                            "  AND SUBJECT LIKE '%{1}%'", mediaType, searchString));
            }
        }
    }
}
