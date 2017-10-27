using System;

namespace SistemaVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Console.WriteLine("Sistema de Vendas");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Digite uma das opções abaixo:");
            Console.WriteLine("1 - Cliente \n2 - Produto \n3 - Venda \n4 - Extrato Cliente \n9 - Sair");
            opcao = Console.ReadLine();

            while(opcao != "9") {
                switch(opcao) {
                    case "1":
                        Console.WriteLine("Cadastro do Cliente");
                        Console.WriteLine("-------------------------");
                        break;
                    case "2":
                        Console.WriteLine("Cadastro de Produtos");
                        Console.WriteLine("-------------------------");  
                        break;                      
                    case "3":
                        Console.WriteLine("Cadastro de Venda");
                        Console.WriteLine("-------------------------");  
                        break;                      
                    case "4":
                        Console.WriteLine("Extrato Cliente");
                        Console.WriteLine("-------------------------");  
                        break;                      
                }                
            }
        }
    }
}
