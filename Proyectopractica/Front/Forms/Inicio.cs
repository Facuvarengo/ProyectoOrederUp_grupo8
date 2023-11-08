using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Inicio : Form
    {
        public Inicio ( )
        {
            InitializeComponent ();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            Registrarse inicio = new Registrarse ();
            inicio.Show ();
            this.Hide ();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            Usuario? usuario = Principal.context.usuarios.FirstOrDefault (u => u.Nombre == txtUsuario1.Text);
            if (usuario != null)
            {


                if (usuario.Contraseña == txtContraseña1.Text)
                {
                    InicioAdm inicio = new InicioAdm ();
                    inicio.Show ();
                    this.Hide ();
                }
                else
                {

                    MessageBox.Show ("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show ("El usuario no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click ( object sender, EventArgs e )
        {
            MenuCompras inicio = new MenuCompras ();
            inicio.Show ();
            this.Hide ();
        }

        private void button2_Click_1 ( object sender, EventArgs e )
        {
            Usuario? usuario = Principal.context.usuarios.FirstOrDefault (u => u.Nombre == txtUsuario1.Text);
            if (usuario != null)
            {


                if (usuario.Contraseña == txtContraseña1.Text)
                {
                    InicioAdm inicio = new InicioAdm ();
                    inicio.Show ();
                    this.Hide ();
                }
                else
                {

                    MessageBox.Show ("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show ("El usuario no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1 ( object sender, EventArgs e )
        {
            Registrarse inicio = new Registrarse ();
            inicio.Show ();
            this.Hide ();
        }
    }
}
