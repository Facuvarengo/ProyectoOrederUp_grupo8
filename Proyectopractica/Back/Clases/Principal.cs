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
            Usuario Usuarios = new Usuario ()
            {
                Nombre = nombre,
                Contraseña = contraseña,

            };

            context.Usuarios.Add (Usuarios);
            context.SaveChanges ();

        }

        public static void EliminarUsuario ( int id )
        {
            Usuario usuario = context.Usuarios.Find (id);
            if (usuario != null)
            {
                context.Usuarios.Remove (usuario);
                context.SaveChanges ();
            }
        }


        public static void ModificarUsuario ( int id, string nuevoNombre, string nuevaContraseña )
        {
            Usuario usuario = context.Usuarios.Find (id);
            if (usuario != null)
            {
                usuario.Nombre = nuevoNombre;
                usuario.Contraseña = nuevaContraseña;
                context.SaveChanges ();
            }
        }


        public static Opcion AgregarOpcion ( string nombre, string tipo, string descripcion, decimal precio, int cantidad )
        {
            Opcion Opciones = new Opcion ()
            {
                Nombre = nombre,
                Tipo = tipo,
                Descripcion = descripcion,
                Precio = precio,
                Cantidad = cantidad,

            };

            context.Opciones.Add (Opciones);
            context.SaveChanges ();
            return Opciones;

        }
        public static void ModificarOpcion ( int id, string nombre, string tipo, string descripcion, decimal precio, int cantidad )
        {
            Opcion opcion = context.Opciones.Find (id);
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
            Opcion opcion = context.Opciones.Find (id);
            context.Opciones.Remove (opcion);
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

            context.Ingredientes.Add (ingrediente);
            context.SaveChanges ();
            return ingrediente;
        }


        public static void EliminarIngredientes ( int id )
        {
            Ingredientes ingrediente = context.Ingredientes.Find (id);
            if (ingrediente != null)
            {
                context.Ingredientes.Remove (ingrediente);
                context.SaveChanges ();
            }
        }

        public static void ModificarIngredientes ( int id, string nombre, string descripcion, decimal precio )
        {
            Ingredientes ingrediente = context.Ingredientes.Find (id);
            if (ingrediente != null)
            {
                ingrediente.Nombre = nombre;
                ingrediente.Descripcion = descripcion;
                ingrediente.Precio = precio;
                context.SaveChanges ();
            }


        }

        //                                     metodos de Pedidos
        public static Pedido AgregarPedido ( DateTime fecha, bool cargado, int cantidad )
        {
            Pedido pedido = new Pedido ()
            {
                Fecha = fecha,
                Cargado = cargado,
                cantidad = cantidad,
            };

            context.Pedidos.Add (pedido);
            context.SaveChanges ();
            return pedido;
        }


        public static void EliminarPedido ( int id )
        {
            Pedido pedido = context.Pedidos.Find (id);
            if (pedido != null)
            {
                context.Pedidos.Remove (pedido);
                context.SaveChanges ();
            }
        }


        public static void ModificarPedido ( int id, DateTime fecha, bool cargado, int cantidad )
        {
            Pedido pedido = context.Pedidos.Find (id);
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