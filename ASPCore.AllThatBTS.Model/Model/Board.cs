using ASPCore.AllThatBTS.Enum;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_BOARD")]
    public class Board
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("BOARD_ID")]
        public string boardId { get; set; }
        [Column("CATEGORY_ID")]
        public string categoryId { get; set; }
        [Column("SUBJECT")]
        public string subject { get; set; }
        [Column("CONTENTS")]
        public string contents { get; set; }
        [Column("READ_CNT")]
        public int readCount { get; set; }
        [Column("RECOMMEND_CNT")]
        public int recommendCount { get; set; }
        [Column("COMMENTS_CNT")]
        public int commentsCount { get; set; }
        [Column("IMAGE_EXIST_YN")]
        public string imageExistYN { get; set; }
        [Column("NICKNAME")]
        public string nickname { get; set; }
        [Column("SECRET")]
        public string secret { get; set; }
        [Column("CREATE_USER")]
        public string createUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime createDatetime { get; set; }
        [Column("UPDATE_USER")]
        public string updateUser { get; set; }
        [Column("UPDATE_DT")]
        public DateTime? updateDatetime { get; set; }

    }
}
