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
  
            List<string> nameS = new List<string>();

            var employeesCount = DataBase.GetTermsCount();
            if (employeesCount < 1)
            {
                Console.WriteLine("Cadastro do primeiro acesso:\n");
            }

            Console.WriteLine("Dados do novo funcionário\n");

            var dictionary = DataBase.GetAllTerms();

            term = NewTerm.TermValidation(term);

            meaning = NewMeaning.MeaningValidation(term);

            Console.WriteLine($"\n {term}: ({meaning}); cadastrado com sucesso!");
            DataBase.SaveDb(term, meaning);
            Console.ReadKey();
        }
        public static void Search()
        {

        }


    }
}
