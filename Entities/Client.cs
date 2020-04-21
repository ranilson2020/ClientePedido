using System;

namespace ClientePedido.Entities
{
    class Client   //Classe Cliente
    {
        //Atributos da Classe
        public string Name { get; set; }  //Nome do Cliente
        public string Email { get; set; } //E-mail do Cliente
        public DateTime BirthDate { get; set; } //Data de Aniversário

        public Client()  //Construtor padrão
        {
        }

        //Contrutor com os Atributos como argumento
        public Client(string name, string email, DateTime birthDate) 
        {
            Name = name;  //nome
            Email = email; // e-mail
            BirthDate = birthDate; //Data de Nascimento
        }

        //Impressão dos dados do cliente

        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
