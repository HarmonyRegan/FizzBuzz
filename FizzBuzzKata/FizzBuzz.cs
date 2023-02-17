using System;
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
                var LuckyRule = new Lucky();
            if (LuckyRule.isApplicable(number))
                return LuckyRule.apply();

                var RuleFizzBuzz = new FizzBuzzRule();
            if (RuleFizzBuzz.isApplicable(number))
                return RuleFizzBuzz.apply();

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

        public string[] Check(int[] input)
            
        {
            var results = new List<string>();
            for (int number = 0; number < input.Count(); number++)
            {
                results.Add(Check(input[number]));
            }
            return results.ToArray();
        }
    }


};
    
