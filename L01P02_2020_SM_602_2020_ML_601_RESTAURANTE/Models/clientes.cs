using System.ComponentModel.DataAnnotations;
namespace L01P02_2020_SM_602_2020_ML_601_RESTAURANTE.Models
{
    public class clientes
    {
        [Key]
        public int clienteId { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
    }
}
