using System.Globalization;

namespace ClientePedido.Entities
{
    class OrderItem
    {
        //Atribultos da classe
        public int Quantity { get; set; }  //Quantidade
        public double Price { get; set; }  //Preço
        public Product Product { get; set; } //Produto

        //Construtor padrão
        public OrderItem()
        {
        }

        //Construtor com Atributos

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        //Declaração dos Métodos
        public double SubTotal()
        {
            return Price * Quantity;    //Retorna Preço x Quantidade
        }

        public override string ToString()     //Impressão usando a função ToString
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}