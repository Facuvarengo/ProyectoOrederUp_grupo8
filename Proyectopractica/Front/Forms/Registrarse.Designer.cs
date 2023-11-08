namespace Front
{
    partial class Registrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Registrarse));
            label1 = new Label ();
            label2 = new Label ();
            txtUsuario = new TextBox ();
            txtContra = new TextBox ();
            button1 = new Button ();
            button2 = new Button ();
            label3 = new Label ();
            panel1 = new Panel ();
            label4 = new Label ();
            pictureBox2 = new PictureBox ();
            panel1.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point (9, 112);
            label1.Name = "label1";
            label1.Size = new Size (47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point (9, 183);
            label2.Name = "label2";
            label2.Size = new Size (67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point (9, 130);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size (100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContra
            // 
            txtContra.Location = new Point (9, 201);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size (100, 23);
            txtContra.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point (14, 277);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 4;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point (95, 277);
            button2.Name = "button2";
            button2.Size = new Size (75, 23);
            button2.TabIndex = 5;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font ("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point (3, 62);
            label3.Name = "label3";
            label3.Size = new Size (177, 15);
            label3.TabIndex = 6;
            label3.Text = "REGISTRAR ADMINISTRADOR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add (label4);
            panel1.Controls.Add (label3);
            panel1.Controls.Add (button1);
            panel1.Controls.Add (button2);
            panel1.Controls.Add (label1);
            panel1.Controls.Add (label2);
            panel1.Controls.Add (txtContra);
            panel1.Controls.Add (txtUsuario);
            panel1.Location = new Point (2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size (192, 449);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font ("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point (0, 0);
            label4.Name = "label4";
            label4.Size = new Size (129, 29);
            label4.TabIndex = 2;
            label4.Text = "ORDER UP";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (799, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (panel1);
            Controls.Add (pictureBox2);
            Name = "Registrarse";
            Text = "Registrarse";
            panel1.ResumeLayout (false);
            panel1.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Button button1;
        private Button button2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
    }
}