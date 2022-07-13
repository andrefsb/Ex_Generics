using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex_01
{
    public class NewExpression
    {
        public static string ExpressionValidation(string term)
        {
            string expression = "";
            do
            {
                Console.Write($"Insert the meaning for the term {term}: ");
                expression = Console.ReadLine();

                if (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == ',' || c == '.') || expression.Length < 1)
                {
                    Console.WriteLine($"The meaning can only have letters and numbers.");
                }
            } while (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == ',' || c == '.') || expression.Length < 1);
            return expression;
        }
        public static string ExpressionValidation()
        {
            string expression = "";
            do
            {
                Console.Write($"Insert the term: ");
                expression = Console.ReadLine();
                if (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-') || expression.Length < 1)
                {
                    Console.WriteLine($"The term can only have letters and numbers.");
                }
                //} while (!Regex.IsMatch(expression, @"^[a-zA-Z0-9]+$"));
            } while (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-') || expression.Length < 1);
            return expression;
        }
    }
}
