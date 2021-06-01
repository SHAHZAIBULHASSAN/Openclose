using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openclose
{
    public class Person : IApplication
    {
        public string name { get; set ; }
        public string lastname { get;set; }
        public IAccount account { get; set; } = new Account();
        public bool IsManager = true;
    }
}
