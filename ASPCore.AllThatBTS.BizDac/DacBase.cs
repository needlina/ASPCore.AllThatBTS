using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.BizDac
{
    public class DacBase
    {
        private IDatabase _Db { get; set; }
        public DacBase()
        {
            IDatabase _Db;
            _Db = new Database("connBTS");
        }
    }
}
