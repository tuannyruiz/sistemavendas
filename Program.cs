using System;
using SistemaVendas.classes;

namespace SistemaVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Vendas");
            Console.WriteLine("-------------------------");

            int opcao = 0;
            while(opcao != 9) {
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("1 - Cliente \n2 - Produto \n3 - Venda \n4 - Extrato Cliente \n9 - Sair");
                opcao = Int32.Parse(Console.ReadLine());
                switch(opcao) {
                    case 1:
                        Console.WriteLine("Digite o nome do cliente:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o email do cliente:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        string cpf = Console.ReadLine();

                        Cliente cl = new Cliente(nome, email, cpf, DateTime.Now.Date);
                        SalvarCliente sc = new SalvarCliente();
                        // Console.WriteLine(new SalvarCliente().Salvar(cl));
                        Console.WriteLine(sc.Salvar(cl));
                        break;

                    case 2:
                        Console.WriteLine("Digite o id do produto:");
                        int id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do produto:");
                        string produto = Console.ReadLine();
                        Console.WriteLine("Digite a descrição:");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto:");
                        double preco = Double.Parse(Console.ReadLine());

                        Produto pr = new Produto(id, produto, descricao, preco);
                        SalvarProduto sp = new SalvarProduto();
                        Console.WriteLine(sp.Salvar(pr));

                        break;                      
 

                }                
            }
        }
    }
}
