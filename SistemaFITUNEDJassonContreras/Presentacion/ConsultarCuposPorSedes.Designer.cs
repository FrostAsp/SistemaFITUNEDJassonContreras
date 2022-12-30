namespace SistemaFITUNEDJassonContreras.Presentacion
{
    partial class ConsultarCuposPorSedes
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
            this.dataGridView_CuposXSedes = new System.Windows.Forms.DataGridView();
            this.label1_noDisponibles = new System.Windows.Forms.Label();
            this.label2_disponibles = new System.Windows.Forms.Label();
            this.label1_sedes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CuposXSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CuposXSedes
            // 
            this.dataGridView_CuposXSedes.AllowUserToAddRows = false;
            this.dataGridView_CuposXSedes.AllowUserToDeleteRows = false;
            this.dataGridView_CuposXSedes.AllowUserToResizeColumns = false;
            this.dataGridView_CuposXSedes.AllowUserToResizeRows = false;
            this.dataGridView_CuposXSedes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_CuposXSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CuposXSedes.Enabled = false;
            this.dataGridView_CuposXSedes.Location = new System.Drawing.Point(115, 239);
            this.dataGridView_CuposXSedes.Name = "dataGridView_CuposXSedes";
            this.dataGridView_CuposXSedes.ReadOnly = true;
            this.dataGridView_CuposXSedes.Size = new System.Drawing.Size(742, 180);
            this.dataGridView_CuposXSedes.TabIndex = 0;
            // 
            // label1_noDisponibles
            // 
            this.label1_noDisponibles.AutoSize = true;
            this.label1_noDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_noDisponibles.ForeColor = System.Drawing.Color.Red;
            this.label1_noDisponibles.Location = new System.Drawing.Point(210, 157);
            this.label1_noDisponibles.Name = "label1_noDisponibles";
            this.label1_noDisponibles.Size = new System.Drawing.Size(143, 25);
            this.label1_noDisponibles.TabIndex = 9;
            this.label1_noDisponibles.Text = "No Disponibles";
            // 
            // label2_disponibles
            // 
            this.label2_disponibles.AutoSize = true;
            this.label2_disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_disponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2_disponibles.Location = new System.Drawing.Point(210, 157);
            this.label2_disponibles.Name = "label2_disponibles";
            this.label2_disponibles.Size = new System.Drawing.Size(113, 25);
            this.label2_disponibles.TabIndex = 8;
            this.label2_disponibles.Text = "Disponibles";
            // 
            // label1_sedes
            // 
            this.label1_sedes.AutoSize = true;
            this.label1_sedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_sedes.ForeColor = System.Drawing.Color.Transparent;
            this.label1_sedes.Location = new System.Drawing.Point(26, 157);
            this.label1_sedes.Name = "label1_sedes";
            this.label1_sedes.Size = new System.Drawing.Size(178, 25);
            this.label1_sedes.TabIndex = 7;
            this.label1_sedes.Text = "Cupos Por Sedes :";
            // 
            // ConsultarCuposPorSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.label1_noDisponibles);
            this.Controls.Add(this.label2_disponibles);
            this.Controls.Add(this.label1_sedes);
            this.Controls.Add(this.dataGridView_CuposXSedes);
            this.Name = "ConsultarCuposPorSedes";
            this.Size = new System.Drawing.Size(916, 708);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CuposXSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CuposXSedes;
        private System.Windows.Forms.Label label1_noDisponibles;
        private System.Windows.Forms.Label label2_disponibles;
        private System.Windows.Forms.Label label1_sedes;
    }
}
