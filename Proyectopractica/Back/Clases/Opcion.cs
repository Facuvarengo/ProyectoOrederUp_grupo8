using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Opcion
    {
        [Key]
        public int IdOpcion { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public List<IngredienteOpcion> ingredientes { get; set; }   = new List<IngredienteOpcion>();

        public List<OpcionPedido> Pedidos { get; set; } = new List<OpcionPedido>();


        public override string ToString()
        {
           return this.Nombre + " " + this.Precio;
        }
        
        public List<Ingredientes> GetIngredientes()
        {
            List<Ingredientes> ingredientes = new List<Ingredientes>();
           
            foreach(IngredienteOpcion io in Principal.context.IngredientesOpciones.ToList())
            {
               if( io.IdOpcion == this.IdOpcion)
                {
                    ingredientes.Add(Principal.context.Ingredientes.Find(io.IdIngrediente));
                }
            }

           return ingredientes;



        }
    }
}
