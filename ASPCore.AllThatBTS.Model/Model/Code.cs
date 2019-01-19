using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_CODE")]
    public class Code
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("CLASS_NAME")]
        public string className { get; set; }
        [Column("TABLE_NAME")]
        public string tableName { get; set; }
        [Column("COL_NAME")]
        public string columnName { get; set; }
        [Column("CODE")]
        public string code { get; set; }
        [Column("CODE_NAME")]
        public string codeName { get; set; }
        [Column("CREATE_USER")]
        public string createUser { get; set; }
        [Column("CREATE_DT")]
        public string createDatetime { get; set; }
        [Column("UPDATE_USER")]
        public string updateUser { get; set; }
        [Column("UPDATE_DT")]
        public string updateDatetime { get; set; }
    }
}
