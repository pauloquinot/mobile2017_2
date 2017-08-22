using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaCSharp
{
    class Program
    {
        public static List<Produto> listaProdutos;

        static void Main(string[] args)
        {
            listaProdutos = new List<Produto>();

            string opcMenu = "";

            do{
                Console.Clear();
                Console.WriteLine("Digite uma opção abaixo: \n\n");
                Console.WriteLine("1 - Inserir\n");
                Console.WriteLine("2 - Alterar\n");
                Console.WriteLine("3 - Excluir\n");
                Console.WriteLine("4 - Listar\n\n");
                Console.WriteLine("0 - Sair\n\n");
                Console.Write("Digite a opção: ");

                opcMenu = Console.ReadLine();

                switch (opcMenu)
                {
                    case "1":
                        Program.Inclui();
                        break;
                    case "2":
                        Program.Altera();
                        break;
                    case "3":
                        break;
                    case "4":
                        foreach(var produto in listaProdutos)
                        {
                            Console.WriteLine("Código: " + produto.Codigo + "  - Nome: " + produto.Nome);
                        }
                        Console.Write("\n\n\nPressione qualquer tecla!");
                        Console.ReadKey();
                        break;
                    case "0":
                        break;
                    default:
                        Console.Write("\n\n\nOpção inválida!!!!");
                        Console.Beep();
                        Console.Write("\n\n\nPressione qualquer tecla!");
                        Console.ReadKey();
                        break;

                }
            } while(opcMenu != "0");
        }
        public static void Inclui()
        {
            Produto novoProduto = new Produto();
            Console.Clear();
            Console.WriteLine("************ Incluir ************\n\n");
            Console.Write("Código: ");
            novoProduto.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNome: ");
            novoProduto.Nome = Console.ReadLine();
            listaProdutos.Add(novoProduto);
        }
        public static void Altera()
        {
            Produto novoProduto = new Produto();
            Console.Clear();
            Console.WriteLine("************ Alterar ************\n\n");
            Console.Write("Digire o código do produto a alterar: ");
            novoProduto.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNome: ");
            novoProduto.Nome = Console.ReadLine();
            listaProdutos.Add(novoProduto);
        }

    }
}
