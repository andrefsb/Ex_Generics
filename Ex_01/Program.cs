//Enunciado
//Você foi contratado pela escola de idiomas “Let’s Speak” para a construção de uma aplicação de dicionário para os alunos.
//A aplicação deve ser construída conforme os requisitos a seguir.

//A aplicação deve armazenar termos e seus significados.
//Os termos podem ser compostos de uma ou mais palavras (como, por exemplo, no caso de phrasal verbs e expressões idiomáticas).

//- A aplicação deve permitir que o aluno insira novos termos sempre que julgar necessário.
//A aplicação deve permitir a busca de termos, não havendo distinção entre maiúsculas e minúsculas.
//- A busca deve ser feita apenas nos termos (não deve fazer buscas nas definições).
//Quando nenhum termo correspondente à busca for encontrado, a aplicação deve exibir na tela a mensagem
//“Nenhum termo encontrado”.
//- Caso contrário, devem ser exibidos todos os termos que correspondem à palavra buscada.
//A aplicação não deve aceitar Wildcards (* e ?), a busca será feita usando-se somente palavras inteiras ou parte de palavras.
//Por exemplo, ao buscar por pea, o sistema deve retornar termos como speak, pear, peacock, spears, etc.
//- A aplicação deve salvar os dados em um arquivo no disco de forma que, ao ser iniciada,
//todos os termos salvos sejam carregados.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ResetColor();
            Console.Title = "Let’s Speak";

            var menu = new MenuItem("Menu Principal");
            var terms = new MenuItem("Dicionário");
            terms.Add(new MenuItem("Cadastrar Palavras", Terms.RegisterTerm));
            terms.Add(new MenuItem("Procurar Palavras", Terms.Search));
            terms.Add(new MenuItem("Listar Palavras", Terms.ListTerms));
            //terms.Add(new MenuItem("Editar Palavra", Terms.EditTerm));
            //terms.Add(new MenuItem("Remover Palavra", Terms.RemoveTerm));
            terms.Add(new MenuItem("Sair", () => Environment.Exit(0)));

            menu.Add(terms);

            menu.Execute();
        }


    }
}

