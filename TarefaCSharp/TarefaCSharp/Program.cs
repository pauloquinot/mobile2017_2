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
                        Program.Exclui();
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
            Int32 codAlterar = 0;
            int indAlterar = -1;
            Console.Clear();
            Console.WriteLine("************ Alterar ************\n\n");
            Console.Write("Digire o código do produto a alterar: ");
            codAlterar = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < listaProdutos.Count; i++)
            {
                if(listaProdutos[i].Codigo == codAlterar)
                {
                    indAlterar = i;
                }
            }
            if (indAlterar > 0)
            {
                Console.Write("\nNome atual: " + listaProdutos[indAlterar].Nome);
                Console.Write("\n\nDigite o novo nome: ");
                listaProdutos[indAlterar].Nome = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\nCódigo não encontrado!!! \n\nPressione uma tecla!");
                Console.ReadKey();
            }
        }
        public static void Exclui()
        {
            Int32 codExcluir = 0;
            int indExcluir = -1;
            string confExclusao = "";
            Console.Clear();
            Console.WriteLine("************ Excluir ************\n\n");
            Console.Write("Digire o código do produto a excluir: ");
            codExcluir = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < listaProdutos.Count; i++)
            {
                if (listaProdutos[i].Codigo == codExcluir)
                {
                    indExcluir = i;
                }
            }
            if (indExcluir > 0)
            {
                Console.Write("\nProduto: " + listaProdutos[indExcluir].Codigo + " - " + listaProdutos[indExcluir].Nome + "\n\n");
                Console.Write("\n\nConfirma Exclusão? (S/N): ");
                confExclusao = Console.ReadLine();
                if(confExclusao == "S" || confExclusao == "s")
                {
                    listaProdutos.RemoveAt(indExcluir);
                }
                else
                {
                    Console.WriteLine("\n\nExclusão não confirmada!! \n\nPressione qualquer tecla!!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\n\nCódigo não encontrado!!! \n\nPressione uma tecla!");
                Console.ReadKey();
            }
        }
    }
}
