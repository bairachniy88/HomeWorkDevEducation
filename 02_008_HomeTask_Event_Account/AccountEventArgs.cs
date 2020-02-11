﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_008_HomeTask_Event_Account
{
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }

    }
}
