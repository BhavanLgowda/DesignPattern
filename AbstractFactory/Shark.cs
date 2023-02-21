﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}