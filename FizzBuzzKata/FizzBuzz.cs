﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    internal class FizzBuzz
    {
        public string Check(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if(number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}