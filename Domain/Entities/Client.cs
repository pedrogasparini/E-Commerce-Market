using Domain.Enums;

namespace Domain.Entities
{
    public class Client : User
    {
        public string ? Adress { get; set; }
        public Client(string name, string lastName, string username, string email, string password, string adress)
        {
            Name = name;
            LastName = lastName;
            UserName = username;
            Email = email;
            Password = password;
            Adress = adress;
            UserType = UserType.Client;
        }

        //Constructor vacio para la db
        public Client() { }
        

    }
}