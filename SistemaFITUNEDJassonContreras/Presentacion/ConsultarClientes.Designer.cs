namespace SistemaFITUNEDJassonContreras.Presentacion
{
    partial class ConsultarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_ConsultarClientes = new System.Windows.Forms.DataGridView();
            this.label1_clientes = new System.Windows.Forms.Label();
            this.label2_disponibles = new System.Windows.Forms.Label();
            this.label1_noDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ConsultarClientes
            // 
            this.dataGridView_ConsultarClientes.AllowUserToAddRows = false;
            this.dataGridView_ConsultarClientes.AllowUserToDeleteRows = false;
            this.dataGridView_ConsultarClientes.AllowUserToResizeColumns = false;
            this.dataGridView_ConsultarClientes.AllowUserToResizeRows = false;
            this.dataGridView_ConsultarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ConsultarClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dataGridView_ConsultarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ConsultarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ConsultarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConsultarClientes.Enabled = false;
            this.dataGridView_ConsultarClientes.GridColor = System.Drawing.Color.White;
            this.dataGridView_ConsultarClientes.Location = new System.Drawing.Point(72, 263);
            this.dataGridView_ConsultarClientes.Name = "dataGridView_ConsultarClientes";
            this.dataGridView_ConsultarClientes.ReadOnly = true;
            this.dataGridView_ConsultarClientes.Size = new System.Drawing.Size(879, 324);
            this.dataGridView_ConsultarClientes.TabIndex = 0;
            // 
            // label1_clientes
            // 
            this.label1_clientes.AutoSize = true;
            this.label1_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_clientes.ForeColor = System.Drawing.Color.Transparent;
            this.label1_clientes.Location = new System.Drawing.Point(95, 190);
            this.label1_clientes.Name = "label1_clientes";
            this.label1_clientes.Size = new System.Drawing.Size(94, 25);
            this.label1_clientes.TabIndex = 1;
            this.label1_clientes.Text = "Clientes :";
            // 
            // label2_disponibles
            // 
            this.label2_disponibles.AutoSize = true;
            this.label2_disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_disponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2_disponibles.Location = new System.Drawing.Point(195, 190);
            this.label2_disponibles.Name = "label2_disponibles";
            this.label2_disponibles.Size = new System.Drawing.Size(113, 25);
            this.label2_disponibles.TabIndex = 2;
            this.label2_disponibles.Text = "Disponibles";
            // 
            // label1_noDisponibles
            // 
            this.label1_noDisponibles.AutoSize = true;
            this.label1_noDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_noDisponibles.ForeColor = System.Drawing.Color.Red;
            this.label1_noDisponibles.Location = new System.Drawing.Point(195, 190);
            this.label1_noDisponibles.Name = "label1_noDisponibles";
            this.label1_noDisponibles.Size = new System.Drawing.Size(143, 25);
            this.label1_noDisponibles.TabIndex = 3;
            this.label1_noDisponibles.Text = "No Disponibles";
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.label1_noDisponibles);
            this.Controls.Add(this.label2_disponibles);
            this.Controls.Add(this.label1_clientes);
            this.Controls.Add(this.dataGridView_ConsultarClientes);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ConsultarClientes";
            this.Size = new System.Drawing.Size(1011, 832);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ConsultarClientes;
        private System.Windows.Forms.Label label1_clientes;
        private System.Windows.Forms.Label label2_disponibles;
        private System.Windows.Forms.Label label1_noDisponibles;
    }
}
