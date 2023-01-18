namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aviso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.tbcontrasena = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASENA";
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Location = new System.Drawing.Point(437, 205);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(10, 13);
            this.aviso.TabIndex = 4;
            this.aviso.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(647, 230);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 6;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // tbcontrasena
            // 
            this.tbcontrasena.Location = new System.Drawing.Point(440, 166);
            this.tbcontrasena.Name = "tbcontrasena";
            this.tbcontrasena.Size = new System.Drawing.Size(310, 20);
            this.tbcontrasena.TabIndex = 7;
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(440, 107);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(310, 20);
            this.tbuser.TabIndex = 8;
            this.tbuser.TextChanged += new System.EventHandler(this.tbuser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "INTRODUZCA EL USUARIO Y CONTRASENA POR FAVOR ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.tbcontrasena);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox tbcontrasena;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label label4;
    }
}

