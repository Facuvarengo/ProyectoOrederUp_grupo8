using Back.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Principal
    {
        public static ApplicationDbContext context = new ApplicationDbContext ();

        public static void AgregarUsuario ( string nombre, string contraseña )
        {
            Usuario usuarios = new Usuario ()
            {
                Nombre = nombre,
                Contraseña = contraseña,

            };

            context.usuarios.Add (usuarios);
            context.SaveChanges ();

        }

        public static void EliminarUsuario ( int id )
        {
            Usuario usuario = context.usuarios.Find (id);
            if (usuario != null)
            {
                context.usuarios.Remove (usuario);
                context.SaveChanges ();
            }
        }


        public static void ModificarUsuario ( int id, string nuevoNombre, string nuevaContraseña )
        {
            Usuario usuario = context.usuarios.Find (id);
            if (usuario != null)
            {
                usuario.Nombre = nuevoNombre;
                usuario.Contraseña = nuevaContraseña;
                context.SaveChanges ();
            }
        }


        public static Opcion AgregarOpcion ( string nombre, string tipo, string descripcion, decimal precio, int cantidad )
        {
            Opcion opciones = new Opcion ()
            {
                Nombre = nombre,
                Tipo = tipo,
                Descripcion = descripcion,
                Precio = precio,
                Cantidad = cantidad,

            };

            context.opciones.Add (opciones);
            context.SaveChanges ();
            return opciones;

        }
        public static void ModificarOpcion ( int id, string nombre, string tipo, string descripcion, decimal precio, int cantidad )
        {
            Opcion opcion = context.opciones.Find (id);
            if (opcion != null)
            {
                opcion.Nombre = nombre;
                opcion.Tipo = tipo;
                opcion.Descripcion = descripcion;
                opcion.Precio = precio;
                opcion.Cantidad = cantidad;
                context.SaveChanges ();
            }
        }
        public static void EliminarOpcion ( int id )
        {
            Opcion opcion = context.opciones.Find (id);
            context.opciones.Remove (opcion);
            context.SaveChanges ();
        }

        //                          Métodos Ingredientes 
        public static Ingredientes AgregarIngredientes ( string nombre, string descripcion, decimal precio )
        {
            Ingredientes ingrediente = new Ingredientes ()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
            };

            context.ingredientes.Add (ingrediente);
            context.SaveChanges ();
            return ingrediente;
        }


        public static void EliminarIngredientes ( int id )
        {
            Ingredientes ingrediente = context.ingredientes.Find (id);
            if (ingrediente != null)
            {
                context.ingredientes.Remove (ingrediente);
                context.SaveChanges ();
            }
        }

        public static void ModificarIngredientes ( int id, string nombre, string descripcion, decimal precio )
        {
            Ingredientes ingrediente = context.ingredientes.Find (id);
            if (ingrediente != null)
            {
                ingrediente.Nombre = nombre;
                ingrediente.Descripcion = descripcion;
                ingrediente.Precio = precio;
                context.SaveChanges ();
            }


        }

        //                                     metodos de pedidos
        public static Pedido AgregarPedido ( DateTime fecha, bool cargado, int cantidad )
        {
            Pedido pedido = new Pedido ()
            {
                Fecha = fecha,
                Cargado = cargado,
                cantidad = cantidad,
            };

            context.pedidos.Add (pedido);
            context.SaveChanges ();
            return pedido;
        }


        public static void EliminarPedido ( int id )
        {
            Pedido pedido = context.pedidos.Find (id);
            if (pedido != null)
            {
                context.pedidos.Remove (pedido);
                context.SaveChanges ();
            }
        }


        public static void ModificarPedido ( int id, DateTime fecha, bool cargado, int cantidad )
        {
            Pedido pedido = context.pedidos.Find (id);
            if (pedido != null)
            {
                pedido.Fecha = fecha;
                pedido.Cargado = cargado;
                pedido.cantidad = cantidad;
                context.SaveChanges ();
            }






        }
    }

}