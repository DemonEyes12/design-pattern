﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    class DQuack:IQuackBehavior
    {
        public string Quack()
        {
            return "Кря кря кря" + this.GetType();
        }
    }
}
