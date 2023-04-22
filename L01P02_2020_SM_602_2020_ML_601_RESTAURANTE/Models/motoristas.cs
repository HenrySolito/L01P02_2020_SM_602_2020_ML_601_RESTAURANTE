using System.ComponentModel.DataAnnotations;

namespace L01P02_2020_SM_602_2020_ML_601_RESTAURANTE.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string nombreMotorista { get; set; }

    }
}
