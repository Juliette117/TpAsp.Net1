using CashRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace CashRegister.Data
{
    public class CashRegisterContext : DbContext
    {
        public CashRegisterContext(DbContextOptions<CashRegisterContext> options) : base(options) { }
        public DbSet<Produit> Produits { get; set; }

    }
}
