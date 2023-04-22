using Microsoft.EntityFrameworkCore;
}using System.ComponentModel.DataAnnotations;
namespace L01P02_2020_SM_602_2020_ML_601_RESTAURANTE.Models
{
    public class platos
    {
        [Key]
        public int platold { get; set; }
        public string? nombrePlato { get; set; }
        public int precio { get; set; }
    }
}
