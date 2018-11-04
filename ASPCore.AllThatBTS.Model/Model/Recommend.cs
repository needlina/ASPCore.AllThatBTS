using ASPCore.AllThatBTS.Enum;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_RECOMMEND")]
    public class Recommend
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("BOARD_SEQ")]
        public string boardSeq { get; set; }
        [Column("COMMENT_SEQ")]
        public string commentSeq { get; set; }
        [Column("RECOMMEND_TYPE")]
        public RecommendType recommendType { get; set; }
        [Column("CREATE_USER")]
        public int CreateUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime CreateDatetime { get; set; }
    }
}
