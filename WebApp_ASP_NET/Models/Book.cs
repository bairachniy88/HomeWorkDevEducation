﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_ASP_NET.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}