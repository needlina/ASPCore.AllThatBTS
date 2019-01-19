using NPoco;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPCore.AllThatBTS.Model
{
    public class BoardInfo
    {
        [Column("BOARD_ID")]
        public string boardId { get; set; }
        [Column("BOARD_NAME")]
        public string boardName { get; set; }
        public List<BoardCategory> categoryList { get; set; }
    }
}
