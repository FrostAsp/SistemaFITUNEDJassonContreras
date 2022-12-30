namespace ProyectoCliente.Presentacion
{
    partial class AplicacionCliente
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
            this.ClienteConectado = new System.Windows.Forms.Label();
            this.ClienteActivo = new System.Windows.Forms.Label();
            this.comboBox_sedesDisponibles = new System.Windows.Forms.ComboBox();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.comboBox_Fechas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClienteConectado
            // 
            this.ClienteConectado.AutoSize = true;
            this.ClienteConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteConectado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClienteConectado.Location = new System.Drawing.Point(12, 22);
            this.ClienteConectado.Name = "ClienteConectado";
            this.ClienteConectado.Size = new System.Drawing.Size(175, 24);
            this.ClienteConectado.TabIndex = 0;
            this.ClienteConectado.Text = "Cliente Conectado :";
            // 
            // ClienteActivo
            // 
            this.ClienteActivo.AutoSize = true;
            this.ClienteActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClienteActivo.Location = new System.Drawing.Point(193, 22);
            this.ClienteActivo.Name = "ClienteActivo";
            this.ClienteActivo.Size = new System.Drawing.Size(372, 25);
            this.ClienteActivo.TabIndex = 1;
            this.ClienteActivo.Text = "Nombre PrimerApellido Segundo Apellido";
            // 
            // comboBox_sedesDisponibles
            // 
            this.comboBox_sedesDisponibles.FormattingEnabled = true;
            this.comboBox_sedesDisponibles.Location = new System.Drawing.Point(16, 144);
            this.comboBox_sedesDisponibles.Name = "comboBox_sedesDisponibles";
            this.comboBox_sedesDisponibles.Size = new System.Drawing.Size(150, 21);
            this.comboBox_sedesDisponibles.TabIndex = 2;
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.button_Aceptar.BackgroundImage = global::ProyectoCliente.Properties.Resources.naranja;
            this.button_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Aceptar.FlatAppearance.BorderSize = 0;
            this.button_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Aceptar.ForeColor = System.Drawing.Color.White;
            this.button_Aceptar.Location = new System.Drawing.Point(427, 461);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(204, 63);
            this.button_Aceptar.TabIndex = 18;
            this.button_Aceptar.Text = "Realizar Reserva";
            this.button_Aceptar.UseVisualStyleBackColor = false;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // comboBox_Fechas
            // 
            this.comboBox_Fechas.FormattingEnabled = true;
            this.comboBox_Fechas.Location = new System.Drawing.Point(16, 250);
            this.comboBox_Fechas.Name = "comboBox_Fechas";
            this.comboBox_Fechas.Size = new System.Drawing.Size(164, 21);
            this.comboBox_Fechas.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Sede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha";
            // 
            // AplicacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(979, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Fechas);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.comboBox_sedesDisponibles);
            this.Controls.Add(this.ClienteActivo);
            this.Controls.Add(this.ClienteConectado);
            this.Name = "AplicacionCliente";
            this.Text = "AplicacionCliente";
            this.Load += new System.EventHandler(this.AplicacionCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClienteConectado;
        private System.Windows.Forms.Label ClienteActivo;
        private System.Windows.Forms.ComboBox comboBox_sedesDisponibles;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.ComboBox comboBox_Fechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}