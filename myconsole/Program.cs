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
                new RedheadDuck()
            };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Quack());
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
            }
            Console.ReadKey();
        }
    }
}

