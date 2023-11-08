namespace Front
{
    partial class MenuCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (MenuCompras));
            dtp = new DateTimePicker ();
            comboBox3 = new ComboBox ();
            comboBox2 = new ComboBox ();
            comboBox1 = new ComboBox ();
            label3 = new Label ();
            label2 = new Label ();
            label1 = new Label ();
            btnagregar = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            button4 = new Button ();
            button1 = new Button ();
            label4 = new Label ();
            listBox1 = new ListBox ();
            pictureBox2 = new PictureBox ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // dtp
            // 
            dtp.Location = new Point (601, 66);
            dtp.Name = "dtp";
            dtp.Size = new Size (200, 23);
            dtp.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point (403, 66);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size (121, 23);
            comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point (205, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size (121, 23);
            comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (3, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (121, 23);
            comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point (403, 48);
            label3.Name = "label3";
            label3.Size = new Size (45, 15);
            label3.TabIndex = 10;
            label3.Text = "Postres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point (205, 48);
            label2.Name = "label2";
            label2.Size = new Size (48, 15);
            label2.TabIndex = 9;
            label2.Text = "Bebidas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point (3, 48);
            label1.Name = "label1";
            label1.Size = new Size (54, 15);
            label1.TabIndex = 8;
            label1.Text = "Comidas";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point (726, 118);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size (75, 23);
            btnagregar.TabIndex = 16;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point (726, 147);
            button2.Name = "button2";
            button2.Size = new Size (75, 23);
            button2.TabIndex = 17;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point (726, 176);
            button3.Name = "button3";
            button3.Size = new Size (75, 23);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point (726, 205);
            button4.Name = "button4";
            button4.Size = new Size (75, 23);
            button4.TabIndex = 19;
            button4.Text = "Comprar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point (726, 234);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 20;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point (3, 9);
            label4.Name = "label4";
            label4.Size = new Size (135, 15);
            label4.TabIndex = 21;
            label4.Text = "ELEGI TU MENU DE HOY";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point (171, 296);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size (690, 154);
            listBox1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (858, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // MenuCompras
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (857, 450);
            Controls.Add (listBox1);
            Controls.Add (label4);
            Controls.Add (button1);
            Controls.Add (button4);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (btnagregar);
            Controls.Add (dtp);
            Controls.Add (comboBox3);
            Controls.Add (comboBox2);
            Controls.Add (comboBox1);
            Controls.Add (label3);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (pictureBox2);
            Name = "MenuCompras";
            Text = "MenuCompras";
            Load += MenuCompras_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private DateTimePicker dtp;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnagregar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Label label4;
        private ListBox listBox1;
        private PictureBox pictureBox2;
    }
}