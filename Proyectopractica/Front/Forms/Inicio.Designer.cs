namespace Front
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Inicio));
            label1 = new Label ();
            button1 = new Button ();
            panel1 = new Panel ();
            pictureBox2 = new PictureBox ();
            button3 = new Button ();
            button2 = new Button ();
            label5 = new Label ();
            label4 = new Label ();
            txtContraseña1 = new TextBox ();
            txtUsuario1 = new TextBox ();
            label3 = new Label ();
            panel1.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font ("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point (0, 0);
            label1.Name = "label1";
            label1.Size = new Size (129, 29);
            label1.TabIndex = 0;
            label1.Text = "ORDER UP";
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.ForeColor = Color.Black;
            button1.Location = new Point (28, 78);
            button1.Name = "button1";
            button1.Size = new Size (138, 215);
            button1.TabIndex = 3;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add (label1);
            panel1.Controls.Add (button1);
            panel1.Font = new Font ("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point (0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size (192, 449);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (799, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point (682, 405);
            button3.Name = "button3";
            button3.Size = new Size (75, 23);
            button3.TabIndex = 25;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point (601, 405);
            button2.Name = "button2";
            button2.Size = new Size (75, 23);
            button2.TabIndex = 24;
            button2.Text = "Iniciar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point (352, 340);
            label5.Name = "label5";
            label5.Size = new Size (67, 15);
            label5.TabIndex = 23;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point (215, 343);
            label4.Name = "label4";
            label4.Size = new Size (47, 15);
            label4.TabIndex = 22;
            label4.Text = "Usuario";
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point (352, 369);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size (100, 23);
            txtContraseña1.TabIndex = 21;
            // 
            // txtUsuario1
            // 
            txtUsuario1.Location = new Point (215, 369);
            txtUsuario1.Name = "txtUsuario1";
            txtUsuario1.Size = new Size (100, 23);
            txtUsuario1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point (215, 309);
            label3.Name = "label3";
            label3.Size = new Size (144, 15);
            label3.TabIndex = 19;
            label3.Text = "SECTOR ADMINISTRADOR";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (800, 450);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (label5);
            Controls.Add (label4);
            Controls.Add (txtContraseña1);
            Controls.Add (txtUsuario1);
            Controls.Add (label3);
            Controls.Add (panel1);
            Controls.Add (pictureBox2);
            Name = "Inicio";
            Text = "Inicio";
            panel1.ResumeLayout (false);
            panel1.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Label label5;
        private Label label4;
        private TextBox txtContraseña1;
        private TextBox txtUsuario1;
        private Label label3;
    }
}