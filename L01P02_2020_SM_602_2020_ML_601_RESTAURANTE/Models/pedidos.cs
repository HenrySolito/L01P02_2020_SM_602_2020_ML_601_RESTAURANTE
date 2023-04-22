using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020_SM_602_2020_ML_601_RESTAURANTE.Models
{
    public class pedidos 
    {
        [Key]

        public int pedidold { get; set; }
        public int motoristald { get; set;}
        public int clienteld { get; set;}
        public int platold { get; set;}
        public int cantidad { get; set;}
        public int precio { get; set;}
    }
    
}
