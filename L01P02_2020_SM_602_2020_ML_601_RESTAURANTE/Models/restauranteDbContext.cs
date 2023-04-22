using Microsoft.EntityFrameworkCore;

namespace L01P02_2020_SM_602_2020_ML_601_RESTAURANTE.Models
{
    public class restauranteDbContext : DbContext
    {
        public restauranteDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
