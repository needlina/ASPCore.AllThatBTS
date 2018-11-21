using ASPCore.AllThatBTS.Enum;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_USER")]
    public class User
    {
        [Column("USER_NO")]
        public int UserNo { get; set; }
        [Column("NICKNAME")]
        public string NickName { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("SECRET")]
        public string Password { get; set; }
        [Column("AUTH_TYPE")]
        public AuthorityType AuthType { get; set; }
        [Column("CONFIRM_YN")]
        public string ConfirmYN { get; set; }
        [Column("CREATE_DT")]
        public DateTime CreateDatetime { get; set; }
        [Column("UPDATE_DT")]
        public DateTime UpdateDatetime { get; set; }
    }
}
