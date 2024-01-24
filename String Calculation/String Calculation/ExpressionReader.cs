using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace String_Calculation
{
    public class ExpressionReader
    {
        private static readonly string _startCommand = "What is";

        public static void Answer(string input)
        {
            if (StartCommandWasNotProvided(input)) return;
            if (ExpressionHasNoNumbers(input)) return;
        }

        private static bool StartCommandWasNotProvided(string input)
        {
            try
            {
                if (input.Contains("What is"))
                {
                    return false;
                }
                else
                {
                    ArgumentValidator.UnsupportedQuestion(input);
                    return true;
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
                return true;
            }
        }

        private static bool ExpressionHasNoNumbers(string input)
        {
            if (!Regex.IsMatch(input, @"\d+"))
            {
                Console.WriteLine($"Your expression needs a least one number");
                return false;
            }
            else
            {
                return true;
            }
        }

        private static string ExtractExpression(string input)
        {
            return input.Replace("What is ", "").Replace("?", "").Trim();
        }



    }
}
