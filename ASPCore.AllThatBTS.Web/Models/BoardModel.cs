using ASPCore.AllThatBTS.Enum;
using ASPCore.AllThatBTS.Model;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Web.Models
{
    public class BoardModel
    {
        public BoardInfoModel boardInfo { get; set; }
        public Page<BoardDataModel> boardDataModelList { get; set; }
    }


    #region 게시물 데이터
    public class BoardDataModel
    {
        public long listNum { get; set; }
        public string seq { get; set; }
        public BoardType boardType { get; set; }
        public string boardId { get; set; }
        public string boardName { get; set; }
        public CategoryType categoryType { get; set; }
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public string subject { get; set; }
        public string contents { get; set; }
        public int readCount { get; set; }
        public int recommendCount { get; set; }
        public int commentsCount { get; set; }
        public string imageExistYN { get; set; }
        public string nickname { get; set; }
        public string secret { get; set; }
        public string createUser { get; set; }
        public DateTime createDatetime { get; set; }
        public string updateUser { get; set; }
        public DateTime? updateDatetime { get; set; }
    }
    #endregion

    #region 게시판 정보 데이터
    public class BoardInfoModel
    {
        public string boardId { get; set; }
        public string boardName { get; set; }
        public List<BoardCategoryModel> categoryList { get; set; }
    }

    public class BoardCategoryModel
    {
        public string seq { get; set; }
        public string boardId { get; set; }
        public CategoryType categoryType { get; set; }
        public string categoryId { get; set; }
        public string categoryName { get; set; }
    }
    #endregion


}
