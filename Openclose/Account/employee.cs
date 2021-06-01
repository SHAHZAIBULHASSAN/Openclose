using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openclose
{
    public class employee : IApplication
    {
        public string name { get ; set; }
        public string lastname { get ; set ; }
        public IAccount account { get; set; } = new Empoyee();
//public Type type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
