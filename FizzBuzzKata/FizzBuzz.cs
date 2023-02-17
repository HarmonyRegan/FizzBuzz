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
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if(number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
        public List<String> Check(int[] numbers)
        {
           
            return numbers.Select(num => Check(num)).ToList();
            
        }

      
    }
}
