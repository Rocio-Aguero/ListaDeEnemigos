namespace ListadeEnemigos.FE
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbOdio = new System.Windows.Forms.ComboBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslagregar = new System.Windows.Forms.ToolStripLabel();
            this.tsleliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tslconsulta = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(194, -24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 161);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE TUS ENEMIGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre o Alias de tus enemigos/a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(488, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel de odio:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(334, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // cmbOdio
            // 
            this.cmbOdio.FormattingEnabled = true;
            this.cmbOdio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOdio.Location = new System.Drawing.Point(603, 97);
            this.cmbOdio.Name = "cmbOdio";
            this.cmbOdio.Size = new System.Drawing.Size(121, 21);
            this.cmbOdio.TabIndex = 4;
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.Color.Red;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.GridColor = System.Drawing.Color.Black;
            this.dgvLista.Location = new System.Drawing.Point(189, 149);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(448, 187);
            this.dgvLista.TabIndex = 5;
            // 
            // tsmMenu
            // 
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslagregar,
            this.tsleliminar,
            this.tslconsulta,
            this.tslSalir});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(800, 27);
            this.tsmMenu.TabIndex = 6;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslagregar
            // 
            this.tslagregar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslagregar.Name = "tslagregar";
            this.tslagregar.Size = new System.Drawing.Size(91, 24);
            this.tslagregar.Text = "Agregar";
            this.tslagregar.Click += new System.EventHandler(this.tslagregar_Click);
            // 
            // tsleliminar
            // 
            this.tsleliminar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsleliminar.Name = "tsleliminar";
            this.tsleliminar.Size = new System.Drawing.Size(91, 24);
            this.tsleliminar.Text = "Eliminar";
            this.tsleliminar.Click += new System.EventHandler(this.tslEliminar_Click);
            // 
            // tslSalir
            // 
            this.tslSalir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(54, 24);
            this.tslSalir.Text = "Salir";
            this.tslSalir.Click += new System.EventHandler(this.tslSalir_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // tslconsulta
            // 
            this.tslconsulta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslconsulta.Name = "tslconsulta";
            this.tslconsulta.Size = new System.Drawing.Size(100, 24);
            this.tslconsulta.Text = "Consulta";
            this.tslconsulta.Click += new System.EventHandler(this.tslconsulta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.cmbOdio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbOdio;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslagregar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolStripLabel tsleliminar;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ToolStripLabel tslconsulta;
    }
}