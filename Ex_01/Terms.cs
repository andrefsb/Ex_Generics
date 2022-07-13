using BetterConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    public class Terms
    {
        public string Term { get; set; }
        public string Meaning { get; set; }

        public Terms(string term, string meaning)
        {
            Term = term;
            Meaning = meaning;
        }
        public Terms() { }

        public static void ListTerms()

        {
            var dictionary = DataBase.GetAllTerms();
            Table table = new Table(TableConfiguration.UnicodeAlt());
            table.From<Terms>(dictionary);

        }
        public static void RegisterTerm()
        {
            string term = "";
            var meaning = "";

            var dictionaryCount = DataBase.GetTermsCount();

            Console.WriteLine("New term data:\n");

            var dictionary = DataBase.GetAllTerms();

            term = NewExpression.ExpressionValidation();

            meaning = NewExpression.ExpressionValidation(term);

            Console.WriteLine($"\n {term}: {meaning}; cadastrado com sucesso!");
            DataBase.SaveDb(term, meaning);
            Console.ReadKey();
        }
        public static void Search()
        {
            string term = "";
            string meaning ="";
            Console.WriteLine("What term do you want to find the description?");
            term = NewExpression.ExpressionValidation();
            DataBase.GetMeaningByTerm(term);
            
        }

    }
}
