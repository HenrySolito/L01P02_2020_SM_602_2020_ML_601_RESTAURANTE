using Microsoft.EntityFrameworkCore;

namespace L01P02_2020_SM_602_2020_ML_601_RESTAURANTE.Models
{
    public class restauranteDbContext : DbContext
    {
        public restauranteDbContext(DbContextOptions <restauranteDbContext> options) : base(options) 
        {
        }
        public DbSet<clientes> clientes { get; set; }
        public DbSet<motoristas> motoristas { get; set; }
        public DbSet<pedidos> pedidos { get; set; }
        public DbSet<platos> platos { get; set; }
    }
}
