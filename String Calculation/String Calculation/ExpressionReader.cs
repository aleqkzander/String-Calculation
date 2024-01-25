using System.Text.RegularExpressions;

namespace String_Calculation
{
    public partial class ExpressionReader
    {
        public static int Answer(string promt)
        {
            return StartSolving(promt);
        }

        private static int StartSolving(string promt)
        {
            try
            {
                string expression = ExtractExpression(promt);
                return SolveMathExpression(expression);
            }
            catch
            {
                throw;
            }
        }

        private static string ExtractExpression(string promt)
        {
            // We make sure input has a valid structure
            if (!promt.Contains("What is")) throw new ArgumentException();
            if (!promt.Contains("?")) throw new ArgumentException();

            // We make sure input has numbers by using a verbatim string literal
            if (!Regex.IsMatch(promt, @"-?\d+")) throw new ArgumentException();

            // Great we can extract the expression
            string expression = promt.Replace("What is ", string.Empty)
            .Replace("by ", string.Empty)
            .Replace("?", string.Empty);
            return expression;
        }

        private static int SolveMathExpression(string expression)
        {
            string[] parts = expression.Split(' ');
            if (parts.Length % 2 == 0) throw new ArgumentException();

            // Make sure result is in correct format
            int result = int.TryParse(parts[0], out int parsedResult) ? parsedResult : throw new ArgumentException();

            for (int i = 1; i < parts.Length; i += 2)
            {
                // Make sure operand is in correct format
                int operand = (i + 1 < parts.Length && int.TryParse(parts[i + 1], out operand)) ? operand : throw new ArgumentException();

                switch (parts[i])
                {
                    case "plus":
                        result += operand;
                        break;

                    case "minus":
                        result -= operand;
                        break;

                    case "multiplied":
                        result *= operand;
                        break;

                    case "divided":
                        if (operand != 0) result /= operand;

                        // No one can divide by zero except for god
                        else throw new ArgumentException();
                        break;

                    // Invalid operator
                    default: throw new ArgumentException();
                }
            }

            return result;
        }
    }
}
