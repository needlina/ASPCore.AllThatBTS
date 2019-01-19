using ASPCore.AllThatBTS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPCore.AllThatBTS.Repository.Interface
{
    interface ICode
    {
        List<Code> SelectAllCode();
        List<Code> SelectAllCodeByTableName(string tableName);
    }
}
