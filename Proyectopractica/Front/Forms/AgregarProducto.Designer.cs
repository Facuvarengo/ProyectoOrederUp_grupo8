namespace Front
{
    partial class AgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (AgregarProducto));
            label1 = new Label ();
            label2 = new Label ();
            label3 = new Label ();
            label4 = new Label ();
            txtNombre = new TextBox ();
            txtTipo = new TextBox ();
            txtDescripcion = new TextBox ();
            txtPrecio = new TextBox ();
            data1 = new DataGridView ();
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            button4 = new Button ();
            label5 = new Label ();
            txtCantidad = new TextBox ();
            comboBoxIngredientes = new ComboBox ();
            button5 = new Button ();
            numericUpDown1 = new NumericUpDown ();
            listBox1 = new ListBox ();
            pictureBox2 = new PictureBox ();
            ((System.ComponentModel.ISupportInitialize)data1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point (39, 63);
            label1.Name = "label1";
            label1.Size = new Size (51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point (57, 95);
            label2.Name = "label2";
            label2.Size = new Size (30, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point (21, 129);
            label3.Name = "label3";
            label3.Size = new Size (69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point (47, 159);
            label4.Name = "label4";
            label4.Size = new Size (40, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point (93, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size (100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point (93, 87);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size (100, 23);
            txtTipo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point (93, 121);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size (100, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point (93, 151);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size (100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // data1
            // 
            data1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data1.Location = new Point (339, 33);
            data1.Name = "data1";
            data1.RowHeadersWidth = 51;
            data1.RowTemplate.Height = 25;
            data1.Size = new Size (413, 232);
            data1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point (339, 290);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point (420, 290);
            button2.Name = "button2";
            button2.Size = new Size (75, 23);
            button2.TabIndex = 10;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point (514, 290);
            button3.Name = "button3";
            button3.Size = new Size (75, 23);
            button3.TabIndex = 11;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point (595, 290);
            button4.Name = "button4";
            button4.Size = new Size (75, 23);
            button4.TabIndex = 12;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point (35, 193);
            label5.Name = "label5";
            label5.Size = new Size (55, 15);
            label5.TabIndex = 13;
            label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point (93, 185);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size (100, 23);
            txtCantidad.TabIndex = 14;
            // 
            // comboBoxIngredientes
            // 
            comboBoxIngredientes.FormattingEnabled = true;
            comboBoxIngredientes.Location = new Point (74, 242);
            comboBoxIngredientes.Margin = new Padding (3, 2, 3, 2);
            comboBoxIngredientes.Name = "comboBoxIngredientes";
            comboBoxIngredientes.Size = new Size (133, 23);
            comboBoxIngredientes.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point (130, 274);
            button5.Name = "button5";
            button5.Size = new Size (75, 23);
            button5.TabIndex = 16;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point (74, 352);
            numericUpDown1.Margin = new Padding (3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size (131, 23);
            numericUpDown1.TabIndex = 17;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point (363, 318);
            listBox1.Margin = new Padding (3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size (132, 79);
            listBox1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (-1, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (802, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (listBox1);
            Controls.Add (numericUpDown1);
            Controls.Add (button5);
            Controls.Add (comboBoxIngredientes);
            Controls.Add (txtCantidad);
            Controls.Add (label5);
            Controls.Add (button4);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (button1);
            Controls.Add (data1);
            Controls.Add (txtPrecio);
            Controls.Add (txtDescripcion);
            Controls.Add (txtTipo);
            Controls.Add (txtNombre);
            Controls.Add (label4);
            Controls.Add (label3);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (pictureBox2);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)data1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private DataGridView data1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private TextBox txtCantidad;
        private ComboBox comboBoxIngredientes;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private PictureBox pictureBox2;
    }
}