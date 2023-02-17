using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public interface iRules
    {
        bool isApplicable(int number);
        string apply();
    }

    public class Lucky : iRules
    {
        public string apply()
        {
            return "Lucky";
        }

        public bool isApplicable(int number)
        {
            return number.ToString().Contains('3');
        }
    }

    public class FizzBuzzRule : iRules
    {
        public string apply()
        {
            return "FizzBuzz";
        }

        public bool isApplicable(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
