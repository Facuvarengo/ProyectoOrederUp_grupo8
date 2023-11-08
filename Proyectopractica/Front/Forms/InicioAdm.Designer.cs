namespace Front
{
    partial class InicioAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (InicioAdm));
            panel1 = new Panel ();
            button1 = new Button ();
            label1 = new Label ();
            button4 = new Button ();
            button3 = new Button ();
            pictureBox2 = new PictureBox ();
            panel1.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add (button1);
            panel1.Controls.Add (label1);
            panel1.Controls.Add (button4);
            panel1.Controls.Add (button3);
            panel1.Location = new Point (1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size (192, 449);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point (28, 195);
            button1.Name = "button1";
            button1.Size = new Size (117, 23);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            label1.TabIndex = 2;
            label1.Text = "ORDER UP";
            // 
            // button4
            // 
            button4.Location = new Point (28, 148);
            button4.Name = "button4";
            button4.Size = new Size (117, 23);
            button4.TabIndex = 1;
            button4.Text = "Ver Reportes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point (28, 106);
            button3.Name = "button3";
            button3.Size = new Size (117, 23);
            button3.TabIndex = 0;
            button3.Text = "Agregar Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (810, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // InicioAdm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (801, 450);
            Controls.Add (panel1);
            Controls.Add (pictureBox2);
            Name = "InicioAdm";
            Text = "InicioAdm";
            panel1.ResumeLayout (false);
            panel1.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
    }
}