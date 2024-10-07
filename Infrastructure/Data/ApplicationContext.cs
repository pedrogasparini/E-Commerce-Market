using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients {get; set;}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        {

        }
    }

}