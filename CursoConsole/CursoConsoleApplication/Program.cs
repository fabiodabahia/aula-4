using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListCli = new List<string>();
            ArrayList ListPrd = new ArrayList();
            String cliente = "", produto = "";
            int opcao, operacao;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Cliente");
                Console.WriteLine("2- Produto");
                Console.WriteLine("3- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("1- Cadastrar Cliente");
                        Console.WriteLine("2- Consultar Cliente");
                        Console.WriteLine("3- Consultar Cliente por Nome");
                        Console.WriteLine("4- Remover Cliente por Nome");
                        break;
                    case 2:
                        Console.WriteLine("1- Cadastrar Produto");
                        Console.WriteLine("2- Consultar Produto");
                        Console.WriteLine("3- Consultar Produto por Nome");
                        Console.WriteLine("4- Remover Produto por Nome");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                if ((opcao.Equals(1)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe o nome:");
                        cliente = Console.ReadLine();
                        ListCli.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    else if ((operacao.Equals(2)))
                    {
                        foreach (String cli in ListCli)
                        {
                            Console.WriteLine("Nome do Cliente: " + cli);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(3))
                    {
                        Console.WriteLine("Informe nome da pesquisa: ");
                        String nomeAux = Console.ReadLine();
                        foreach (var item in ListCli)
                        {
                            if (item.Equals(nomeAux))
                                Console.WriteLine("Achei {0}!", item);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.WriteLine("Informe nome da remoção: ");
                        String nomeAux = Console.ReadLine();
                        bool removeu = ListCli.Remove(nomeAux);
                        if (removeu)
                            Console.WriteLine("Cliente removido com sucesso!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
                else if ((opcao.Equals(2)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe  o nome:");
                        produto = Console.ReadLine();
                        ListPrd.Add(produto);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    else if ((operacao.Equals(2)))
                    {
                        foreach (var prd in ListPrd)
                        {
                            Console.WriteLine("Descrição: " + prd);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(3))
                    {
                        String descAux = Console.ReadLine();
                        foreach (var item in ListPrd)
                        {
                            if (item.Equals(descAux))
                                Console.WriteLine("Achei {0}!", item);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.WriteLine("Informe nome da remoção: ");
                        String descAux = Console.ReadLine();
                        foreach (var item in ListPrd)
                        {
                            if (item.Equals(descAux))
                            {
                                ListPrd.Remove(item);
                                Console.WriteLine("Produto removido com sucesso!");
                                break;
                            }
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
            } while (opcao != 3);
        }
    }
}
