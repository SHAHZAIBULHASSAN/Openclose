using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openclose
{
    public class super : IApplication
    {
        public string name { get; set ; }
        public string lastname { get ; set ; }
        public bool IsManager = true;
        public bool IsManagerss = true;
        public IAccount account { get; set; } = new SuperAccount();
    }
}
