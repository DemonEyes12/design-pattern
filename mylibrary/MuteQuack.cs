using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    class MuteQuack:IQuackBehavior
    {
        public string Quack()
        {
            return "" + this.GetType();
        }
    }
}
