namespace SistemaFITUNEDJassonContreras.Presentacion
{
    partial class RegistroClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_segundoApellido = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_guardarSedes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_PrimerApellido = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_NombreCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_identificadorCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker_fechaIngreso);
            this.panel1.Controls.Add(this.dateTimePicker_fechaNacimiento);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox_genero);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_segundoApellido);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBox_PrimerApellido);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox_NombreCliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox_identificadorCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(232, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 514);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker_fechaIngreso
            // 
            this.dateTimePicker_fechaIngreso.Location = new System.Drawing.Point(202, 443);
            this.dateTimePicker_fechaIngreso.Name = "dateTimePicker_fechaIngreso";
            this.dateTimePicker_fechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaIngreso.TabIndex = 22;
            this.dateTimePicker_fechaIngreso.Value = new System.DateTime(2022, 4, 21, 1, 29, 0, 0);
            // 
            // dateTimePicker_fechaNacimiento
            // 
            this.dateTimePicker_fechaNacimiento.Location = new System.Drawing.Point(202, 324);
            this.dateTimePicker_fechaNacimiento.Name = "dateTimePicker_fechaNacimiento";
            this.dateTimePicker_fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaNacimiento.TabIndex = 6;
            this.dateTimePicker_fechaNacimiento.Value = new System.DateTime(2022, 4, 21, 1, 29, 0, 0);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel8.Location = new System.Drawing.Point(202, 469);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(196, 2);
            this.panel8.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel5.Location = new System.Drawing.Point(202, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 2);
            this.panel5.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(19, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Fecha de Ingreso :";
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_genero.Location = new System.Drawing.Point(202, 390);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(121, 21);
            this.comboBox_genero.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel6.Location = new System.Drawing.Point(202, 297);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(196, 2);
            this.panel6.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha Nacimiento  :";
            // 
            // textBox_segundoApellido
            // 
            this.textBox_segundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.textBox_segundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_segundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_segundoApellido.ForeColor = System.Drawing.Color.White;
            this.textBox_segundoApellido.Location = new System.Drawing.Point(202, 277);
            this.textBox_segundoApellido.Name = "textBox_segundoApellido";
            this.textBox_segundoApellido.Size = new System.Drawing.Size(196, 14);
            this.textBox_segundoApellido.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btn_guardarSedes);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(535, 62);
            this.panel7.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(150, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Registro Clientes";
            // 
            // btn_guardarSedes
            // 
            this.btn_guardarSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_guardarSedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardarSedes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_guardarSedes.FlatAppearance.BorderSize = 0;
            this.btn_guardarSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarSedes.Image = global::SistemaFITUNEDJassonContreras.Properties.Resources.boton_agregar;
            this.btn_guardarSedes.Location = new System.Drawing.Point(448, 0);
            this.btn_guardarSedes.Name = "btn_guardarSedes";
            this.btn_guardarSedes.Size = new System.Drawing.Size(87, 62);
            this.btn_guardarSedes.TabIndex = 0;
            this.btn_guardarSedes.UseVisualStyleBackColor = false;
            this.btn_guardarSedes.Click += new System.EventHandler(this.btn_guardarSedes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(202, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 2);
            this.panel4.TabIndex = 11;
            // 
            // textBox_PrimerApellido
            // 
            this.textBox_PrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.textBox_PrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrimerApellido.ForeColor = System.Drawing.Color.White;
            this.textBox_PrimerApellido.Location = new System.Drawing.Point(202, 222);
            this.textBox_PrimerApellido.Name = "textBox_PrimerApellido";
            this.textBox_PrimerApellido.Size = new System.Drawing.Size(196, 14);
            this.textBox_PrimerApellido.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(202, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 2);
            this.panel3.TabIndex = 9;
            // 
            // textBox_NombreCliente
            // 
            this.textBox_NombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.textBox_NombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NombreCliente.ForeColor = System.Drawing.Color.White;
            this.textBox_NombreCliente.Location = new System.Drawing.Point(202, 172);
            this.textBox_NombreCliente.Name = "textBox_NombreCliente";
            this.textBox_NombreCliente.Size = new System.Drawing.Size(198, 14);
            this.textBox_NombreCliente.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel2.Location = new System.Drawing.Point(202, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 2);
            this.panel2.TabIndex = 7;
            // 
            // textBox_identificadorCliente
            // 
            this.textBox_identificadorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.textBox_identificadorCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_identificadorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_identificadorCliente.ForeColor = System.Drawing.Color.White;
            this.textBox_identificadorCliente.Location = new System.Drawing.Point(202, 109);
            this.textBox_identificadorCliente.Name = "textBox_identificadorCliente";
            this.textBox_identificadorCliente.Size = new System.Drawing.Size(198, 14);
            this.textBox_identificadorCliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Apellido  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(108, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(44, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(102, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador :";
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.panel1);
            this.Name = "RegistroClientes";
            this.Size = new System.Drawing.Size(959, 942);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaIngreso;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaNacimiento;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_segundoApellido;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guardarSedes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_PrimerApellido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_NombreCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_identificadorCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
