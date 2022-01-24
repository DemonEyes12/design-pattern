using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    public abstract class Duck
    {
       protected IFlyBehavior flyBehavior;
       protected IQuackBehavior quackBehavior;
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public string Swim()
        {
            return "Swim" + this.GetType();
        }
        public abstract string Display();

    }
}
