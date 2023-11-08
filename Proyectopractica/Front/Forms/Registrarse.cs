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
    public partial class Registrarse : Form
    {
        Principal principal = new Principal ();

        public Registrarse ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {

            Principal.AgregarUsuario (txtUsuario.Text, txtContra.Text);
            MessageBox.Show ("Usuario creado pa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            Inicio inicio = new Inicio ();
            inicio.Show ();
            this.Hide ();
        }
    }
}
