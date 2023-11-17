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
            this.tboxDiagnostico = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.Label();
            this.ComDiagnostico = new System.Windows.Forms.Label();
            this.datFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.ComReceta = new System.Windows.Forms.Label();
            this.tboxReceta = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPaciente
            // 
            this.txtPaciente.AutoSize = true;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(12, 39);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(71, 15);
            this.txtPaciente.TabIndex = 0;
            this.txtPaciente.Text = "Paciente :";
            this.txtPaciente.Click += new System.EventHandler(this.label1_Click);
            // 
            // tboxDiagnostico
            // 
            this.tboxDiagnostico.Location = new System.Drawing.Point(112, 176);
            this.tboxDiagnostico.Name = "tboxDiagnostico";
            this.tboxDiagnostico.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tboxDiagnostico.Size = new System.Drawing.Size(510, 96);
            this.tboxDiagnostico.TabIndex = 1;
            this.tboxDiagnostico.Text = resources.GetString("tboxDiagnostico.Text");
            this.tboxDiagnostico.TextChanged += new System.EventHandler(this.tboxDiagnostico_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Mario Alejandro Miranda Rosales\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "181 LB";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.AutoSize = true;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(12, 83);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(47, 15);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.Text = "Peso :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "36º C";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.AutoSize = true;
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(12, 129);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(97, 15);
            this.txtTemperatura.TabIndex = 5;
            this.txtTemperatura.Text = "Temperatura :";
            // 
            // ComDiagnostico
            // 
            this.ComDiagnostico.AutoSize = true;
            this.ComDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComDiagnostico.Location = new System.Drawing.Point(12, 177);
            this.ComDiagnostico.Name = "ComDiagnostico";
            this.ComDiagnostico.Size = new System.Drawing.Size(91, 15);
            this.ComDiagnostico.TabIndex = 7;
            this.ComDiagnostico.Text = "Diagnostico :";
            // 
            // datFecha
            // 
            this.datFecha.AutoSize = true;
            this.datFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecha.Location = new System.Drawing.Point(612, 21);
            this.datFecha.Name = "datFecha";
            this.datFecha.Size = new System.Drawing.Size(54, 15);
            this.datFecha.TabIndex = 9;
            this.datFecha.Text = "Fecha :";
            this.datFecha.Click += new System.EventHandler(this.datFecha_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(672, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(637, 408);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(145, 40);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ComReceta
            // 
            this.ComReceta.AutoSize = true;
            this.ComReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComReceta.Location = new System.Drawing.Point(15, 312);
            this.ComReceta.Name = "ComReceta";
            this.ComReceta.Size = new System.Drawing.Size(92, 15);
            this.ComReceta.TabIndex = 13;
            this.ComReceta.Text = "Receta med :";
            // 
            // tboxReceta
            // 
            this.tboxReceta.Location = new System.Drawing.Point(112, 311);
            this.tboxReceta.Name = "tboxReceta";
            this.tboxReceta.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tboxReceta.Size = new System.Drawing.Size(510, 96);
            this.tboxReceta.TabIndex = 12;
            this.tboxReceta.Text = "Aspirina 100mg.\nPrueba Holder.\nEcocardiograma.\nExamen general de sangre.\nExamen t" +
    "roponina T.";
            // 
            // DetalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.ComReceta);
            this.Controls.Add(this.tboxReceta);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.ComDiagnostico);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tboxDiagnostico);
            this.Controls.Add(this.txtPaciente);
            this.Name = "DetalleCita";
            this.Text = "Detalle de cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPaciente;
        private System.Windows.Forms.RichTextBox tboxDiagnostico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtPeso;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtTemperatura;
        private System.Windows.Forms.Label ComDiagnostico;
        private System.Windows.Forms.Label datFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label ComReceta;
        private System.Windows.Forms.RichTextBox tboxReceta;
    }
}

