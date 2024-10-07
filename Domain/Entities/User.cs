using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public string? Name { get; set; }
        public string? LastName {get; set;}
        public string? UserName {get; set;}
        public string? Email {get; set;}
        public string? Password {get; set;}
        public UserType UserType {get; set;}
    }
}