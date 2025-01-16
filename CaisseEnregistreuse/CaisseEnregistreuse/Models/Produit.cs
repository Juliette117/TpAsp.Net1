using System.ComponentModel.DataAnnotations;

namespace CashRegister.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0.01, int.MaxValue, ErrorMessage ="Le prix doit être superieur à 0.")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Picture { get; set; }
        public int CategorieId {  get; set; }
        public Categorie Categorie { get; set; }





    }
}
