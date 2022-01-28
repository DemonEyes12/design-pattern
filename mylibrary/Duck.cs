using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    public abstract class Duck
    {
       public IFlyBehavior flyBehavior;
       public IQuackBehavior quackBehavior;
        public string Display()
        {
            return "Display" + this.GetType()  + flyBehavior.Fly() + quackBehavior.Quack();
        }
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

    }
}
