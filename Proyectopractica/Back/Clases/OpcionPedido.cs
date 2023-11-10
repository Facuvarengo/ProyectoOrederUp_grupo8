using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class OpcionPedido
    {

        [Key]
        public int IdOpcionPedido{ get; set; }

        [ForeignKey(nameof(Pedidos))]

        public int IdPedido { get; set; }

        public Pedido Pedidos { get; set; } = null!;

        [ForeignKey(nameof(Opcion))]
        public int IdOpcion { get; set; }
        public Opcion Opcion { get; set; } = null!;

    }
}
