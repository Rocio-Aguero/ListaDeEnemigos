namespace ListaDeEnemigos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.Clavelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(107, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 151);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDOS A TU LISTA DE ENEMIGOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolbl.Location = new System.Drawing.Point(144, 135);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(94, 24);
            this.Usuariolbl.TabIndex = 1;
            this.Usuariolbl.Text = "Usuario:";
            // 
            // Clavelbl
            // 
            this.Clavelbl.AutoSize = true;
            this.Clavelbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clavelbl.Location = new System.Drawing.Point(144, 192);
            this.Clavelbl.Name = "Clavelbl";
            this.Clavelbl.Size = new System.Drawing.Size(74, 24);
            this.Clavelbl.TabIndex = 2;
            this.Clavelbl.Text = "Clave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbtn.Location = new System.Drawing.Point(280, 243);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbtn.TabIndex = 6;
            this.Aceptarbtn.Text = "Aceptar";
            this.Aceptarbtn.UseVisualStyleBackColor = true;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aceptarbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clavelbl);
            this.Controls.Add(this.Usuariolbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Usuariolbl;
        private System.Windows.Forms.Label Clavelbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Aceptarbtn;
    }
}

