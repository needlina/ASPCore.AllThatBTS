using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_COMMENT")]
    public class Comment
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("BOARD_SEQ")]
        public string boardSeq { get; set; }
        [Column("PARENT_COMMENT_SEQ")]
        public string parentCommentSeq { get; set; }
        [Column("COMMENTS")]
        public string comments { get; set; }
        [Column("DEPTH")]
        public int depth { get; set; }
        [Column("RECOMMEND_CNT")]
        public int recommendCnt { get; set; }
        [Column("COMMENTS_CNT")]
        public int commentsCnt { get; set; }
        [Column("CREATE_USER")]
        public int createUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime createDatetime { get; set; }
        [Column("UPDATE_USER")]
        public int updateUser { get; set; }
        [Column("UPDATE_DT")]
        public DateTime updateDatetime { get; set; }

    }
}
