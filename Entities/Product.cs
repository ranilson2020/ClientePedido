namespace ClientePedido.Entities
{
    class Product
    {
        //Declaração dos Atributos
        public string Name { get; set; }  //nome
        public double Price { get; set; }  //preço

        public Product()  //Construtor padrão
        {
        }
        
        public Product(string name, double price)  //Construtor com atributos
        {
            Name = name;  //nome
            Price = price; //preço
        }
    }
}