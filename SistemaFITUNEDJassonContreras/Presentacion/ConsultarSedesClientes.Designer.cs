namespace SistemaFITUNEDJassonContreras
{
    partial class ConsultarSedesClientes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Sedes = new System.Windows.Forms.DataGridView();
            this.dataGridView_AfiliacionClienteSede = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AfiliacionClienteSede)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Sedes
            // 
            this.dataGridView_Sedes.AllowUserToAddRows = false;
            this.dataGridView_Sedes.AllowUserToDeleteRows = false;
            this.dataGridView_Sedes.AllowUserToResizeColumns = false;
            this.dataGridView_Sedes.AllowUserToResizeRows = false;
            this.dataGridView_Sedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Sedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dataGridView_Sedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Sedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sedes.Enabled = false;
            this.dataGridView_Sedes.GridColor = System.Drawing.Color.White;
            this.dataGridView_Sedes.Location = new System.Drawing.Point(69, 154);
            this.dataGridView_Sedes.Name = "dataGridView_Sedes";
            this.dataGridView_Sedes.ReadOnly = true;
            this.dataGridView_Sedes.Size = new System.Drawing.Size(846, 349);
            this.dataGridView_Sedes.TabIndex = 0;
            this.dataGridView_Sedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sedes_CellContentClick);
            // 
            // dataGridView_AfiliacionClienteSede
            // 
            this.dataGridView_AfiliacionClienteSede.AllowUserToAddRows = false;
            this.dataGridView_AfiliacionClienteSede.AllowUserToDeleteRows = false;
            this.dataGridView_AfiliacionClienteSede.AllowUserToResizeColumns = false;
            this.dataGridView_AfiliacionClienteSede.AllowUserToResizeRows = false;
            this.dataGridView_AfiliacionClienteSede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AfiliacionClienteSede.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_AfiliacionClienteSede.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dataGridView_AfiliacionClienteSede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AfiliacionClienteSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AfiliacionClienteSede.Enabled = false;
            this.dataGridView_AfiliacionClienteSede.GridColor = System.Drawing.Color.White;
            this.dataGridView_AfiliacionClienteSede.Location = new System.Drawing.Point(69, 604);
            this.dataGridView_AfiliacionClienteSede.Name = "dataGridView_AfiliacionClienteSede";
            this.dataGridView_AfiliacionClienteSede.ReadOnly = true;
            this.dataGridView_AfiliacionClienteSede.Size = new System.Drawing.Size(541, 151);
            this.dataGridView_AfiliacionClienteSede.TabIndex = 0;
            // 
            // ConsultarSedesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.dataGridView_AfiliacionClienteSede);
            this.Controls.Add(this.dataGridView_Sedes);
            this.Name = "ConsultarSedesClientes";
            this.Size = new System.Drawing.Size(958, 1003);
            this.Load += new System.EventHandler(this.ConsultarSedesClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AfiliacionClienteSede)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Sedes;
        private System.Windows.Forms.DataGridView dataGridView_AfiliacionClienteSede;
    }
}
