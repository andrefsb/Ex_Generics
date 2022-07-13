using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ex_01
{
    internal class DataBase
    {
        static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionary.xml");
        static List<Terms> dictionary;
        static DataBase()
        {
            if (!File.Exists(dbPath))
            {
                var dictionary0 = new List<Terms>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Terms>));
                TextWriter write0 = new StreamWriter(dbPath);

                serializer.Serialize(write0, dictionary0);

                write0.Close();
            }
            dictionary = LoadDb();

        }

        internal static int GetTermsCount()
        {
            return dictionary.Count;
        }

        private static List<Terms> LoadDb()
        {
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Terms>));
                TextReader reader = new StreamReader(dbPath);
                var objeto = serializer.Deserialize(reader);

                reader.Close();
                return (List<Terms>)objeto;
            }
        }

        public static void SaveDb(string term, string description)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Terms>));
            TextWriter write = new StreamWriter(dbPath);
            DataBase.dictionary.Add(new Terms(term, description));
            serializer.Serialize(write, term);
            write.Close();
        }

        //public static Terms GetDescriptionByTerm(string logginEntry)
        //{
        //    foreach (var t in dictionary)
        //    {
        //        if (Entry == term.)
        //            return term;
        //    }
        //    return null;
        //}
        public static List<Terms> GetAllTerms()
        {
            return dictionary.AsReadOnly().ToList();
        }
    }
}

