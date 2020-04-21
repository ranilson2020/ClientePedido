using System;
using System.Globalization;
using ClientePedido.Entities;
using ClientePedido.Entities.Enums;

namespace ClientePedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: "); //Entre com os dados do cliente
            Console.Write("Name: ");  //Nome
            string clientName = Console.ReadLine();
            Console.Write("Email: "); //E-mail
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): "); //Data Nascimento
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: "); //Entre com os dados do Pedido
            Console.Write("Status: ");  //status
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);  //Fazendo a associação com o objeto Cliente
            Order order = new Order(DateTime.Now, status, client);    //Fazendo a associação com o objeto Pedido 

            Console.Write("How many items to this order? "); //Quantos itens para este pedido?
            int n = int.Parse(Console.ReadLine());  //variável n, declarada para saber quanto itens terá o pedido

            for (int i = 1; i <= n; i++)  //Para i=1; enquanto i menor ou igual n; i recebi i+1
            {
                Console.WriteLine($"Enter #{i} item data:"); //Entre com os dados do item
                Console.Write("Product name: ");   //Nome do Produto
                string productName = Console.ReadLine();
                Console.Write("Product price: ");  //Preço do Produto
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura do preço

                Product product = new Product(productName, price); //Fazendo a associação do objeto Produto

                Console.Write("Quantity: "); // Quantidade
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product); //Fazendo associação do objeto OrderItem [PedidoItem]

                order.AddItem(orderItem);  //Adcione o item
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:"); //Resumo do Pedido
            Console.WriteLine(order);  //Imprima o Pedido
        }
    }
}