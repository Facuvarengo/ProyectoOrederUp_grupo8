using Back.Clases;
using Microsoft.EntityFrameworkCore;
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
    public partial class MenuCompras : Form
    {
        public MenuCompras ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            Inicio inicio = new Inicio ();
            inicio.Show ();
            this.Hide ();
        }

        private void MenuCompras_Load ( object sender, EventArgs e )
        {
            Principal.context.Opciones.Load ();
            comboBox1.DataSource = null;
            comboBox1.DataSource = Principal.context.Opciones.Where (o => o.Tipo == "Comidas").ToList ();

            comboBox2.DataSource = null;
            comboBox2.DataSource = Principal.context.Opciones.Where (o => o.Tipo == "Bebidas").ToList ();

            comboBox3.DataSource = null;
            comboBox3.DataSource = Principal.context.Opciones.Where (o => o.Tipo == "Postres").ToList ();


        }

        private void btnagregar_Click ( object sender, EventArgs e )
        {
            listBox1.Items.Add (comboBox1.SelectedItem);

            listBox1.Items.Add (comboBox2.SelectedItem);

            listBox1.Items.Add (comboBox3.SelectedItem);

            listBox1.Items.Add (dtp.Value.ToString ());


        }
    }
}
