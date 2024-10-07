using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public UserType UserType {get; set;}

        public static ClientDto Create(Client client)
        {
            return new ClientDto
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                UserName = client.UserName,
                Email = client.Email,
                Adress = client.Adress,
                UserType = UserType.Client
            };
        }

        public static List<ClientDto> CreateList(IEnumerable<Client> client)
        {
            return client.Select(Create).ToList();
        }

    }
}