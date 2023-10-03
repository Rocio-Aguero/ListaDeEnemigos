namespace ListadeEnemigos.FE
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
            this.btcrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtburuario = new System.Windows.Forms.TextBox();
            this.txtbcontrasena = new System.Windows.Forms.TextBox();
            this.btingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO A LA LISTA DE ENEMIGOS";
            // 
            // btcrear
            // 
            this.btcrear.Location = new System.Drawing.Point(362, 170);
            this.btcrear.Name = "btcrear";
            this.btcrear.Size = new System.Drawing.Size(75, 23);
            this.btcrear.TabIndex = 1;
            this.btcrear.Text = "CREAR";
            this.btcrear.UseVisualStyleBackColor = true;
            this.btcrear.Click += new System.EventHandler(this.btcrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA";
            // 
            // txtburuario
            // 
            this.txtburuario.Location = new System.Drawing.Point(373, 77);
            this.txtburuario.Name = "txtburuario";
            this.txtburuario.Size = new System.Drawing.Size(145, 20);
            this.txtburuario.TabIndex = 4;
            this.txtburuario.TextChanged += new System.EventHandler(this.txtburuario_TextChanged);
            // 
            // txtbcontrasena
            // 
            this.txtbcontrasena.Location = new System.Drawing.Point(373, 122);
            this.txtbcontrasena.Name = "txtbcontrasena";
            this.txtbcontrasena.Size = new System.Drawing.Size(145, 20);
            this.txtbcontrasena.TabIndex = 5;
            this.txtbcontrasena.UseSystemPasswordChar = true;
            // 
            // btingresar
            // 
            this.btingresar.Location = new System.Drawing.Point(443, 170);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(75, 23);
            this.btingresar.TabIndex = 6;
            this.btingresar.Text = "INGRESAR";
            this.btingresar.UseVisualStyleBackColor = true;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btingresar);
            this.Controls.Add(this.txtbcontrasena);
            this.Controls.Add(this.txtburuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcrear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtburuario;
        private System.Windows.Forms.TextBox txtbcontrasena;
        private System.Windows.Forms.Button btingresar;
    }
}

