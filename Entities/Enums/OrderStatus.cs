namespace ClientePedido.Entities.Enums
{
    enum OrderStatus : int   // Criação do enum 
    {
        PendingPayment = 0,  //Pagamento Pendente
        Processing = 1,     //Processando
        Shipped = 2,        //Enviado
        Delivered = 3      // Entregue        
    }
}
