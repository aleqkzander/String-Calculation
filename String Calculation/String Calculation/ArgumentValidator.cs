using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_Calculation
{
    public class ArgumentValidator
    {
        public static void UnsupportedQuestion(string input)
        {
            if (!input.Contains("What is"))
            {
                throw new ArgumentException("A valid question starts with: What is");
            }

            if (!Regex.IsMatch(input, @"\d+"))
            {
                throw new ArgumentException("A valid question need numbers");
            }
        }
    }
}
