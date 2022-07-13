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
                Console.Write($"Insira a descrição para o termo '{term}': ");
                expression = Console.ReadLine();

                if (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == ',' || c == '.') || expression.Length < 1)
                {
                    Console.WriteLine($"O significado deve conter apenas letras e números.");
                }
            } while (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == ',' || c == '.') || expression.Length < 1);
            return expression;
        }
        public static string ExpressionValidation()
        {
            string expression = "";
            do
            {
                Console.Write($"Insira o termo: ");
                expression = Console.ReadLine();
                if (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-') || expression.Length < 1)
                {
                    Console.WriteLine($"O termo deve conter apenas letras e números.");
                }
                //} while (!Regex.IsMatch(expression, @"^[a-zA-Z0-9]+$"));
            } while (!expression.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-') || expression.Length < 1);
            return expression;
        }
    }
}
