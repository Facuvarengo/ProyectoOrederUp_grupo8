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
    public partial class InicioAdm : Form
    {
        public InicioAdm ( )
        {
            InitializeComponent ();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            AgregarProducto inicio = new AgregarProducto ();
            inicio.Show ();
            this.Hide ();
        }

        private void button4_Click ( object sender, EventArgs e )
        {
            Reportes inicio = new Reportes ();
            inicio.Show ();
            this.Hide ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            Inicio inicio = new Inicio ();
            inicio.Show ();
            this.Hide ();
        }
    }
}
