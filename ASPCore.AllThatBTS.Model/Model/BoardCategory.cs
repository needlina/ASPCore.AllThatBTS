using NPoco;
using System;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_BOARD_CATEGORY")]
    public class BoardCategory
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("BOARD_ID")]
        public string boardId { get; set; }
        [Column("CATEGORY_ID")]
        public string categoryId { get; set; }
        [Column("CATEGORY_NAME")]
        public string categoryName { get; set; }
        [Column("CREATE_USER")]
        public string createUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime createDatetime { get; set; }
        [Column("UPDATE_USER")]
        public string updateUser { get; set; }
        [Column("UPDATE_DT")]
        public DateTime updateDatetime { get; set; }
    }
}
