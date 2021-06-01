using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openclose
{
    public class staff : IApplication
    {
        public string name { get ; set ; }
        public string lastname { get ; set; }
        public IAccount account { get; set; } = new SuperAccount(); public bool IsManagerj = true;
    }
}
