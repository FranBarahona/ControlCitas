namespace ControlCitas
{
    partial class DetalleCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCita));
            this.txtPaciente = new System.Windows.Forms.Label();
            this.txtBoxDiagnostico = new System.Windows.Forms.RichTextBox();
            this.txtBoxPaciente = new System.Windows.Forms.TextBox();
            this.txtBoxPeso = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.Label();
            this.txtBoxTemp = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.Label();
            this.ComDiagnostico = new System.Windows.Forms.Label();
            this.datFecha = new System.Windows.Forms.Label();
            this.dtPickerFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.ComReceta = new System.Windows.Forms.Label();
            this.txtBoxReceta = new System.Windows.Forms.RichTextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPaciente
            // 
            this.txtPaciente.AutoSize = true;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(52, 63);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(71, 15);
            this.txtPaciente.TabIndex = 0;
            this.txtPaciente.Text = "Paciente :";
            this.txtPaciente.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxDiagnostico
            // 
            this.txtBoxDiagnostico.Location = new System.Drawing.Point(152, 200);
            this.txtBoxDiagnostico.Name = "txtBoxDiagnostico";
            this.txtBoxDiagnostico.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtBoxDiagnostico.Size = new System.Drawing.Size(510, 96);
            this.txtBoxDiagnostico.TabIndex = 1;
            this.txtBoxDiagnostico.Text = resources.GetString("txtBoxDiagnostico.Text");
            this.txtBoxDiagnostico.TextChanged += new System.EventHandler(this.tboxDiagnostico_TextChanged);
            // 
            // txtBoxPaciente
            // 
            this.txtBoxPaciente.Location = new System.Drawing.Point(152, 62);
            this.txtBoxPaciente.Name = "txtBoxPaciente";
            this.txtBoxPaciente.Size = new System.Drawing.Size(213, 20);
            this.txtBoxPaciente.TabIndex = 2;
            this.txtBoxPaciente.Text = "Mario Alejandro Miranda Rosales\r\n";
            // 
            // txtBoxPeso
            // 
            this.txtBoxPeso.Location = new System.Drawing.Point(152, 106);
            this.txtBoxPeso.Name = "txtBoxPeso";
            this.txtBoxPeso.Size = new System.Drawing.Size(79, 20);
            this.txtBoxPeso.TabIndex = 4;
            this.txtBoxPeso.Text = "181 LB";
            this.txtBoxPeso.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.AutoSize = true;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(52, 107);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(47, 15);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.Text = "Peso :";
            // 
            // txtBoxTemp
            // 
            this.txtBoxTemp.Location = new System.Drawing.Point(152, 152);
            this.txtBoxTemp.Name = "txtBoxTemp";
            this.txtBoxTemp.Size = new System.Drawing.Size(79, 20);
            this.txtBoxTemp.TabIndex = 6;
            this.txtBoxTemp.Text = "36º C";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.AutoSize = true;
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(52, 153);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(97, 15);
            this.txtTemperatura.TabIndex = 5;
            this.txtTemperatura.Text = "Temperatura :";
            // 
            // ComDiagnostico
            // 
            this.ComDiagnostico.AutoSize = true;
            this.ComDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComDiagnostico.Location = new System.Drawing.Point(52, 201);
            this.ComDiagnostico.Name = "ComDiagnostico";
            this.ComDiagnostico.Size = new System.Drawing.Size(91, 15);
            this.ComDiagnostico.TabIndex = 7;
            this.ComDiagnostico.Text = "Diagnostico :";
            // 
            // datFecha
            // 
            this.datFecha.AutoSize = true;
            this.datFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecha.Location = new System.Drawing.Point(616, 24);
            this.datFecha.Name = "datFecha";
            this.datFecha.Size = new System.Drawing.Size(54, 15);
            this.datFecha.TabIndex = 9;
            this.datFecha.Text = "Fecha :";
            this.datFecha.Click += new System.EventHandler(this.datFecha_Click);
            // 
            // dtPickerFechaConsulta
            // 
            this.dtPickerFechaConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtPickerFechaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFechaConsulta.Location = new System.Drawing.Point(672, 24);
            this.dtPickerFechaConsulta.Name = "dtPickerFechaConsulta";
            this.dtPickerFechaConsulta.Size = new System.Drawing.Size(101, 21);
            this.dtPickerFechaConsulta.TabIndex = 10;
            // 
            // ComReceta
            // 
            this.ComReceta.AutoSize = true;
            this.ComReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComReceta.Location = new System.Drawing.Point(55, 336);
            this.ComReceta.Name = "ComReceta";
            this.ComReceta.Size = new System.Drawing.Size(92, 15);
            this.ComReceta.TabIndex = 13;
            this.ComReceta.Text = "Receta med :";
            // 
            // txtBoxReceta
            // 
            this.txtBoxReceta.Location = new System.Drawing.Point(152, 335);
            this.txtBoxReceta.Name = "txtBoxReceta";
            this.txtBoxReceta.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtBoxReceta.Size = new System.Drawing.Size(510, 96);
            this.txtBoxReceta.TabIndex = 12;
            this.txtBoxReceta.Text = "Aspirina 100mg.\nPrueba Holder.\nEcocardiograma.\nExamen general de sangre.\nExamen t" +
    "roponina T.";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(56, 16);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.ComReceta);
            this.Controls.Add(this.txtBoxReceta);
            this.Controls.Add(this.dtPickerFechaConsulta);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.ComDiagnostico);
            this.Controls.Add(this.txtBoxTemp);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtBoxPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtBoxPaciente);
            this.Controls.Add(this.txtBoxDiagnostico);
            this.Controls.Add(this.txtPaciente);
            this.Name = "DetalleCita";
            this.Text = "Detalle de cita";
            this.Load += new System.EventHandler(this.DetalleCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPaciente;
        private System.Windows.Forms.RichTextBox txtBoxDiagnostico;
        private System.Windows.Forms.TextBox txtBoxPaciente;
        private System.Windows.Forms.TextBox txtBoxPeso;
        private System.Windows.Forms.Label txtPeso;
        private System.Windows.Forms.TextBox txtBoxTemp;
        private System.Windows.Forms.Label txtTemperatura;
        private System.Windows.Forms.Label ComDiagnostico;
        private System.Windows.Forms.Label datFecha;
        private System.Windows.Forms.DateTimePicker dtPickerFechaConsulta;
        private System.Windows.Forms.Label ComReceta;
        private System.Windows.Forms.RichTextBox txtBoxReceta;
        private System.Windows.Forms.Button btnRegresar;
    }
}

