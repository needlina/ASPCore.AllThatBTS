using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_TAG")]
    public class Tag
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("BOARD_SEQ")]
        public string boardSeq { get; set; }
        [Column("TAG")]
        public string tag { get; set; }
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
