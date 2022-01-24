using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mylibrary;

namespace myconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = new Duck[]
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck(),
            };
/*
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
                if (duck is IFlyBehavior)
                {
                    Console.WriteLine((duck as IFlyBehavior).Fly());

                }
                if (duck is IQuackBehavior)
                {
                    Console.WriteLine((duck as IQuackBehavior).Quack());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
*/
        }
    }
}

