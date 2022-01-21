﻿using System;
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

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).Fly());

                }
                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).Quack());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

