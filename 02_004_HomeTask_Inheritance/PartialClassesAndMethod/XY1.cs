﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_004_HomeTask_Inheritance.PartialClassesAndMethod
{
    partial class XY
    {
        public XY (int a, int b)
        {
            X = a;
            Y = b;
        }

        partial void Show();
    }
}
