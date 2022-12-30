namespace SistemaFITUNEDJassonContreras.Presentacion
{
    partial class ConsultarSedes
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
            this.dataGridView_ConsultarSedes = new System.Windows.Forms.DataGridView();
            this.label1_noDisponibles = new System.Windows.Forms.Label();
            this.label2_disponibles = new System.Windows.Forms.Label();
            this.label1_sedes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultarSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ConsultarSedes
            // 
            this.dataGridView_ConsultarSedes.AllowUserToAddRows = false;
            this.dataGridView_ConsultarSedes.AllowUserToDeleteRows = false;
            this.dataGridView_ConsultarSedes.AllowUserToResizeColumns = false;
            this.dataGridView_ConsultarSedes.AllowUserToResizeRows = false;
            this.dataGridView_ConsultarSedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ConsultarSedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dataGridView_ConsultarSedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ConsultarSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConsultarSedes.Enabled = false;
            this.dataGridView_ConsultarSedes.GridColor = System.Drawing.Color.Black;
            this.dataGridView_ConsultarSedes.Location = new System.Drawing.Point(52, 258);
            this.dataGridView_ConsultarSedes.Name = "dataGridView_ConsultarSedes";
            this.dataGridView_ConsultarSedes.Size = new System.Drawing.Size(879, 324);
            this.dataGridView_ConsultarSedes.TabIndex = 1;
            // 
            // label1_noDisponibles
            // 
            this.label1_noDisponibles.AutoSize = true;
            this.label1_noDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_noDisponibles.ForeColor = System.Drawing.Color.Red;
            this.label1_noDisponibles.Location = new System.Drawing.Point(194, 187);
            this.label1_noDisponibles.Name = "label1_noDisponibles";
            this.label1_noDisponibles.Size = new System.Drawing.Size(143, 25);
            this.label1_noDisponibles.TabIndex = 6;
            this.label1_noDisponibles.Text = "No Disponibles";
            // 
            // label2_disponibles
            // 
            this.label2_disponibles.AutoSize = true;
            this.label2_disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_disponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2_disponibles.Location = new System.Drawing.Point(194, 187);
            this.label2_disponibles.Name = "label2_disponibles";
            this.label2_disponibles.Size = new System.Drawing.Size(113, 25);
            this.label2_disponibles.TabIndex = 5;
            this.label2_disponibles.Text = "Disponibles";
            // 
            // label1_sedes
            // 
            this.label1_sedes.AutoSize = true;
            this.label1_sedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_sedes.ForeColor = System.Drawing.Color.Transparent;
            this.label1_sedes.Location = new System.Drawing.Point(94, 187);
            this.label1_sedes.Name = "label1_sedes";
            this.label1_sedes.Size = new System.Drawing.Size(80, 25);
            this.label1_sedes.TabIndex = 4;
            this.label1_sedes.Text = "Sedes :";
            // 
            // ConsultarSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.label1_noDisponibles);
            this.Controls.Add(this.label2_disponibles);
            this.Controls.Add(this.label1_sedes);
            this.Controls.Add(this.dataGridView_ConsultarSedes);
            this.Name = "ConsultarSedes";
            this.Size = new System.Drawing.Size(1030, 831);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultarSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ConsultarSedes;
        private System.Windows.Forms.Label label1_noDisponibles;
        private System.Windows.Forms.Label label2_disponibles;
        private System.Windows.Forms.Label label1_sedes;
    }
}
