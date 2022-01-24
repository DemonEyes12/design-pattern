using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    public class RedheadDuck : Duck,IFlyBehavior,IQuackBehavior
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }
        public string Fly()
        {
            return "fly" + this.GetType();
        }
        public string Quack()
        {
            return "quack" + this.GetType();
        }
    }
}
