using System.ComponentModel.DataAnnotations;

namespace CashRegister.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
