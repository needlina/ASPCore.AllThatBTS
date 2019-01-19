using ASPCore.AllThatBTS.Enum;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_USER_AUTHORITY")]
    public class UserAuthority
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("USER_NO")]
        public string userNo { get; set; }
        [Column("USER_GRADE")]
        public UserGradeType userGrade { get; set; }
        [Column("CREATE_USER")]
        public string CreateUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime CreateDatetime { get; set; }
        [Column("UPDATE_USER")]
        public string UpdateUser { get; set; }
        [Column("UPDATE_DT")]
        public DateTime UpdateDatetime { get; set; }
    }
}
