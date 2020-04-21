using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using ClientePedido.Entities.Enums;

namespace ClientePedido.Entities
{
    class Order    //Classe Pedido
    {
        public DateTime Moment { get; set; }  //Data e Hora  ex: 20/04/2020 23:41:22
        public OrderStatus Status { get; set; } //Status
        public Client Client { get; set; }  //Cliente
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();  // Lista de Itens

        public Order()  //Construtor padrão
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)  //Contrutor com os atributos do pedido
        {
            Moment = moment;    //Data e Hora
            Status = status;    //Status    
            Client = client;    //Cliente
        }

        //Declaração dos Métodos
        public void AddItem(OrderItem item)
        {
            Items.Add(item);  //Adciona os Itens
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);  //Remove itens
        }

        //Método Totalizar o pedido
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();  //soma = soma+ itens
            }
            return sum;
        }

        //Impressão do Pedido
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: R$ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
