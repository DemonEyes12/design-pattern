using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    class Squeak:IQuackBehavior
    {
        public string Quack()
        {
            return "Пи Пи Пи" + this.GetType();
        }
    }
}
