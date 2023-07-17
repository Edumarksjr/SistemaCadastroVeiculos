using Microsoft.EntityFrameworkCore;
using SistemaCadastroVeiculos.Models;

namespace SistemaCadastroVeiculos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
         }
        
        public DbSet<VeiculoModel> Veiculos { get; set; }    

    }
}
