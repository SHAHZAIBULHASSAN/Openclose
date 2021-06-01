using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openclose
{
    class Executive_account : IAccount
    {
        public Person Create(IApplication application)
        {
            Person per = new Person();
            per.name = application.name;
            per.lastname = application.lastname;
            // per.type = application.type;
            per.account = application.account;
            return per;
        }
    }
}
