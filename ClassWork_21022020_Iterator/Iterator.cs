﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_21022020_Iterator
{
    abstract class Iterator
    {
        public abstract object First(); 
        public abstract object Next(); 
        public abstract bool IsDone(); 
        public abstract object CurrentItem();
    }
}
