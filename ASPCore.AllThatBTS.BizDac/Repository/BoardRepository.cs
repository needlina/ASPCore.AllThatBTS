using ASPCore.AllThatBTS.Common;
using ASPCore.AllThatBTS.Model;
using ASPCore.AllThatBTS.Repository.Interface;
using NPoco;
using System;

namespace ASPCore.AllThatBTS.Repository
{
    public class BoardRepository : IBoard
    {
        private string connectionString;

        public BoardRepository()
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

        public object InsertBoardData(Board board)
        {
            return Connection.Insert(board);
        }

        public Board SelectBoardData(string seq)
        {
            return Connection.Single<Board>(string.Format("SELECT * FROM TB_BOARD WHERE SEQ = '{0}'", seq));
        }

        public Page<Board> SelectBoardDataListWithPage(string boardId, int pageNo = 1, int pageSize = 20)
        {
            return Connection.Page<Board>(pageNo, pageSize, string.Format("SELECT * FROM TB_BOARD WHERE BOARD_ID = '{0}' ORDER BY CREATE_DT DESC", boardId));
        }

        public int UpdateBoardData(Board board)
        {
            return Connection.Update(board);
        }

        public int DeleteBoardData(string seq)
        {
            return Connection.Delete<Board>(seq);
        }

        public BoardInfo SelectBoardInfo(string boardId)
        {
            BoardInfo boardInfo = Connection.Single<BoardInfo>(string.Format("SELECT A.CODE BOARD_ID, A.CODE_NAME BOARD_NAME " +
                                                                             "FROM TB_CODE A WHERE COL_NAME = 'BOARD_ID'" +
                                                                             "AND CODE = '{0}'", boardId));
            boardInfo.categoryList = Connection.Fetch<BoardCategory>(string.Format("SELECT * " +
                                                                                   "FROM TB_BOARD_CATEGORY WHERE BOARD_ID = '{0}'", boardId));

            return boardInfo;
        }
    }
}
