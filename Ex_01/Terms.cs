using BetterConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;


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
            Console.WriteLine("Total de palavras cadastradas: " + DataBase.GetTermsCount());
            Console.Write(table.ToString());
        }
        public static void RegisterTerm()
        {
            string term = "";
            var meaning = "";

            var dictionaryCount = DataBase.GetTermsCount();

            Console.WriteLine("Informações do novo termo:\n");

            term = NewExpression.ExpressionValidation();

            meaning = NewExpression.ExpressionValidation(term);

            Console.WriteLine($"\n {term}: {meaning}; cadastrado com sucesso!");
            DataBase.SaveDb(term, meaning);
            Console.ReadKey();
        }
        public static void Search()
        {
            string term = "";
            string meaning = "";
            Console.WriteLine("Total de palavras já cadastradas: " + DataBase.GetTermsCount());
            Console.WriteLine("Para qual termo deseja encontrar a descrição?");
            term = NewExpression.ExpressionValidation();
            DataBase.GetMeaningByTerm(term);

        }
        public static void RemoveTerm()
        {
            //string term = "";
            //var meaning = "";

            //term = NewExpression.ExpressionValidation();

            //meaning = NewExpression.ExpressionValidation(term);

            //Console.WriteLine($"Deseja remover '{term}': {meaning}?");

            //Console.WriteLine($"\n {term}: {meaning}; removido com sucesso!");
            //DataBase.SaveDb(term, meaning);
            //Console.ReadKey();
        }
        public static void EditTerm()
        {
            //var word = Prompt.Select("Seleciona o termo para editar", , defaultValue:);

            //Prompt.Bind(term);

            //Save.SaveDb();
        }
    }
}
