﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Stask
{
    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name = {0}", this.Name);
        }
    }
}
