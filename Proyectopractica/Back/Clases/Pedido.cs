using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        public bool Cargado { get; set; }
        public int cantidad { get; set; }

        public List<OpcionPedido> Opciones { get; set; } = null!; 

        
    }
}
