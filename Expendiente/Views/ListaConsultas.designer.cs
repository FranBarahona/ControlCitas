namespace ControlCitas
{
    partial class ListaConsultas
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNonPatientOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnCrearCita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbBoxSatuses = new System.Windows.Forms.ComboBox();
            this.btnEditarConsulta = new System.Windows.Forms.Button();
            this.btnVerConsulta = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lbFiltroHasta = new System.Windows.Forms.Label();
            this.lbFiltroDesde = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.listadoConsultas = new System.Windows.Forms.ListView();
            this.summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlNonPatientOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(41, 11);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlNonPatientOptions);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 464);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // pnlNonPatientOptions
            // 
            this.pnlNonPatientOptions.Controls.Add(this.btnPacientes);
            this.pnlNonPatientOptions.Controls.Add(this.btnCrearCita);
            this.pnlNonPatientOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlNonPatientOptions.Name = "pnlNonPatientOptions";
            this.pnlNonPatientOptions.Size = new System.Drawing.Size(712, 48);
            this.pnlNonPatientOptions.TabIndex = 16;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(3, 3);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(341, 45);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnCrearCita
            // 
            this.btnCrearCita.Location = new System.Drawing.Point(350, 3);
            this.btnCrearCita.Name = "btnCrearCita";
            this.btnCrearCita.Size = new System.Drawing.Size(354, 45);
            this.btnCrearCita.TabIndex = 1;
            this.btnCrearCita.Text = "Crear Cita";
            this.btnCrearCita.UseVisualStyleBackColor = true;
            this.btnCrearCita.Click += new System.EventHandler(this.btnCrearCita_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cmbBoxSatuses);
            this.panel1.Controls.Add(this.btnEditarConsulta);
            this.panel1.Controls.Add(this.btnVerConsulta);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.lbFiltroHasta);
            this.panel1.Controls.Add(this.lbFiltroDesde);
            this.panel1.Controls.Add(this.dateTimePickerHasta);
            this.panel1.Controls.Add(this.dateTimePickerDesde);
            this.panel1.Controls.Add(this.listadoConsultas);
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 392);
            this.panel1.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(330, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbBoxSatuses
            // 
            this.cmbBoxSatuses.FormattingEnabled = true;
            this.cmbBoxSatuses.Location = new System.Drawing.Point(378, 7);
            this.cmbBoxSatuses.Name = "cmbBoxSatuses";
            this.cmbBoxSatuses.Size = new System.Drawing.Size(144, 21);
            this.cmbBoxSatuses.TabIndex = 22;
            // 
            // btnEditarConsulta
            // 
            this.btnEditarConsulta.Location = new System.Drawing.Point(562, 119);
            this.btnEditarConsulta.Name = "btnEditarConsulta";
            this.btnEditarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarConsulta.TabIndex = 21;
            this.btnEditarConsulta.Text = "Editar";
            this.btnEditarConsulta.UseVisualStyleBackColor = true;
            this.btnEditarConsulta.Click += new System.EventHandler(this.btnEditarConsulta_Click);
            // 
            // btnVerConsulta
            // 
            this.btnVerConsulta.Location = new System.Drawing.Point(643, 118);
            this.btnVerConsulta.Name = "btnVerConsulta";
            this.btnVerConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnVerConsulta.TabIndex = 20;
            this.btnVerConsulta.Text = "Ver";
            this.btnVerConsulta.UseVisualStyleBackColor = true;
            this.btnVerConsulta.Click += new System.EventHandler(this.btnVerConsulta_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(6, 83);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lbFiltroHasta
            // 
            this.lbFiltroHasta.AutoSize = true;
            this.lbFiltroHasta.Location = new System.Drawing.Point(3, 47);
            this.lbFiltroHasta.Name = "lbFiltroHasta";
            this.lbFiltroHasta.Size = new System.Drawing.Size(38, 13);
            this.lbFiltroHasta.TabIndex = 17;
            this.lbFiltroHasta.Text = "Hasta:";
            // 
            // lbFiltroDesde
            // 
            this.lbFiltroDesde.AutoSize = true;
            this.lbFiltroDesde.Location = new System.Drawing.Point(3, 7);
            this.lbFiltroDesde.Name = "lbFiltroDesde";
            this.lbFiltroDesde.Size = new System.Drawing.Size(41, 13);
            this.lbFiltroDesde.TabIndex = 18;
            this.lbFiltroDesde.Text = "Desde:";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(50, 47);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 15;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(50, 7);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 16;
            // 
            // listadoConsultas
            // 
            this.listadoConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.summary,
            this.date});
            this.listadoConsultas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listadoConsultas.HideSelection = false;
            this.listadoConsultas.HoverSelection = true;
            this.listadoConsultas.Location = new System.Drawing.Point(3, 147);
            this.listadoConsultas.MultiSelect = false;
            this.listadoConsultas.Name = "listadoConsultas";
            this.listadoConsultas.Size = new System.Drawing.Size(715, 239);
            this.listadoConsultas.TabIndex = 14;
            this.listadoConsultas.UseCompatibleStateImageBehavior = false;
            this.listadoConsultas.View = System.Windows.Forms.View.Details;
            // 
            // summary
            // 
            this.summary.Text = "Resumen";
            this.summary.Width = 213;
            // 
            // date
            // 
            this.date.Text = "Fecha/Hora";
            this.date.Width = 362;
            // 
            // ListaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ListaConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ListaConsultas_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlNonPatientOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlNonPatientOptions;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnCrearCita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbBoxSatuses;
        private System.Windows.Forms.Button btnEditarConsulta;
        private System.Windows.Forms.Button btnVerConsulta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lbFiltroHasta;
        private System.Windows.Forms.Label lbFiltroDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.ListView listadoConsultas;
        private System.Windows.Forms.ColumnHeader summary;
        private System.Windows.Forms.ColumnHeader date;
    }
}

