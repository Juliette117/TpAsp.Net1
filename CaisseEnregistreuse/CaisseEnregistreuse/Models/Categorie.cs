namespace CashRegister.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Produit> Produits { get; set; }
    }
}
