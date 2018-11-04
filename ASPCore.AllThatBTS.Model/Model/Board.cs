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
        public BoardType boardID { get; set; }
        [Column("CATEGORY_ID")]
        public CategoryType categoryType { get; set; }
        [Column("SUBJECT")]
        public string subject { get; set; }
        [Column("CONTENTS")]
        public string contents { get; set; }
        [Column("READ_CNT")]
        public int readCount { get; set; }
        [Column("RECOMMEND_CNT")]
        public int recommendCnt { get; set; }
        [Column("COMMENTS_CNT")]
        public int commentsCount { get; set; }
        [Column("IMAGE_EXIST_YN")]
        public bool imageExistYN { get; set; }
        [Column("CREATE_USER")]
        public int CreateUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime CreateDatetime { get; set; }
        [Column("UPDATE_USER")]
        public int UpdateUser { get; set; }
        [Column("UPDATE_DT")]
        public DateTime UpdateDatetime { get; set; }
    }
}
