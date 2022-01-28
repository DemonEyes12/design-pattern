using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new DQuack();
            flyBehavior = new FlyWithWings();
      
        }
    }
}
