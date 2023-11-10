using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ingredientes> Ingredientes { get; set; }
        public DbSet<Opcion> Opciones { get; set; }    
        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<IngredienteOpcion> IngredientesOpciones { get; set; }  
        public DbSet<OpcionPedido> OpcionPedido { get; set; }        




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4U7JAH5\\SQLEXPRESS;database=ProyectoPractica;trusted_connection=true;Encrypt=False");
        }

       


    }
}
