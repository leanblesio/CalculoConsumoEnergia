namespace CalculoConsumoEnergia
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
            this.lblFase1 = new System.Windows.Forms.Label();
            this.lblFase2 = new System.Windows.Forms.Label();
            this.lblFaseD5 = new System.Windows.Forms.Label();
            this.dtpFechaConsumo = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tbFase1 = new System.Windows.Forms.TextBox();
            this.tbFase2 = new System.Windows.Forms.TextBox();
            this.tbFaseD5 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFase1
            // 
            this.lblFase1.AutoSize = true;
            this.lblFase1.Location = new System.Drawing.Point(26, 96);
            this.lblFase1.Name = "lblFase1";
            this.lblFase1.Size = new System.Drawing.Size(43, 13);
            this.lblFase1.TabIndex = 0;
            this.lblFase1.Text = "FASE 1";
            // 
            // lblFase2
            // 
            this.lblFase2.AutoSize = true;
            this.lblFase2.Location = new System.Drawing.Point(26, 129);
            this.lblFase2.Name = "lblFase2";
            this.lblFase2.Size = new System.Drawing.Size(43, 13);
            this.lblFase2.TabIndex = 1;
            this.lblFase2.Text = "FASE 2";
            // 
            // lblFaseD5
            // 
            this.lblFaseD5.AutoSize = true;
            this.lblFaseD5.Location = new System.Drawing.Point(26, 160);
            this.lblFaseD5.Name = "lblFaseD5";
            this.lblFaseD5.Size = new System.Drawing.Size(51, 13);
            this.lblFaseD5.TabIndex = 2;
            this.lblFaseD5.Text = "FASE D5";
            // 
            // dtpFechaConsumo
            // 
            this.dtpFechaConsumo.Location = new System.Drawing.Point(90, 64);
            this.dtpFechaConsumo.Name = "dtpFechaConsumo";
            this.dtpFechaConsumo.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaConsumo.TabIndex = 3;
            this.dtpFechaConsumo.ValueChanged += new System.EventHandler(this.dtpFechaConsumo_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(27, 67);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "FECHA";
            this.lblFecha.UseWaitCursor = true;
            // 
            // tbFase1
            // 
            this.tbFase1.Location = new System.Drawing.Point(90, 94);
            this.tbFase1.Name = "tbFase1";
            this.tbFase1.Size = new System.Drawing.Size(135, 20);
            this.tbFase1.TabIndex = 5;
            // 
            // tbFase2
            // 
            this.tbFase2.Location = new System.Drawing.Point(90, 127);
            this.tbFase2.Name = "tbFase2";
            this.tbFase2.Size = new System.Drawing.Size(135, 20);
            this.tbFase2.TabIndex = 6;
            // 
            // tbFaseD5
            // 
            this.tbFaseD5.Location = new System.Drawing.Point(90, 158);
            this.tbFaseD5.Name = "tbFaseD5";
            this.tbFaseD5.Size = new System.Drawing.Size(135, 20);
            this.tbFaseD5.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(150, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "$/kW";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(74, 270);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(35, 13);
            this.lblConsumo.TabIndex = 12;
            this.lblConsumo.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 317);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbFaseD5);
            this.Controls.Add(this.tbFase2);
            this.Controls.Add(this.tbFase1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaConsumo);
            this.Controls.Add(this.lblFaseD5);
            this.Controls.Add(this.lblFase2);
            this.Controls.Add(this.lblFase1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFase1;
        private System.Windows.Forms.Label lblFase2;
        private System.Windows.Forms.Label lblFaseD5;
        private System.Windows.Forms.DateTimePicker dtpFechaConsumo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox tbFase1;
        private System.Windows.Forms.TextBox tbFase2;
        private System.Windows.Forms.TextBox tbFaseD5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConsumo;
    }
}

