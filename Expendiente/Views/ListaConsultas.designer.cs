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
            this.listadoConsultas = new System.Windows.Forms.ListView();
            this.summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.lbFiltroDesde = new System.Windows.Forms.Label();
            this.lbFiltroHasta = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerConsulta = new System.Windows.Forms.Button();
            this.btnVerReceta = new System.Windows.Forms.Button();
            this.btnEditarConsulta = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listadoConsultas
            // 
            this.listadoConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.summary,
            this.date});
            this.listadoConsultas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listadoConsultas.HideSelection = false;
            this.listadoConsultas.HoverSelection = true;
            this.listadoConsultas.Location = new System.Drawing.Point(41, 180);
            this.listadoConsultas.MultiSelect = false;
            this.listadoConsultas.Name = "listadoConsultas";
            this.listadoConsultas.Size = new System.Drawing.Size(715, 239);
            this.listadoConsultas.TabIndex = 0;
            this.listadoConsultas.UseCompatibleStateImageBehavior = false;
            this.listadoConsultas.View = System.Windows.Forms.View.Details;
            this.listadoConsultas.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(88, 40);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 1;
            // 
            // lbFiltroDesde
            // 
            this.lbFiltroDesde.AutoSize = true;
            this.lbFiltroDesde.Location = new System.Drawing.Point(41, 40);
            this.lbFiltroDesde.Name = "lbFiltroDesde";
            this.lbFiltroDesde.Size = new System.Drawing.Size(41, 13);
            this.lbFiltroDesde.TabIndex = 5;
            this.lbFiltroDesde.Text = "Desde:";
            // 
            // lbFiltroHasta
            // 
            this.lbFiltroHasta.AutoSize = true;
            this.lbFiltroHasta.Location = new System.Drawing.Point(41, 80);
            this.lbFiltroHasta.Name = "lbFiltroHasta";
            this.lbFiltroHasta.Size = new System.Drawing.Size(38, 13);
            this.lbFiltroHasta.TabIndex = 5;
            this.lbFiltroHasta.Text = "Hasta:";
            this.lbFiltroHasta.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(88, 80);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(44, 116);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnVerConsulta
            // 
            this.btnVerConsulta.Location = new System.Drawing.Point(681, 151);
            this.btnVerConsulta.Name = "btnVerConsulta";
            this.btnVerConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnVerConsulta.TabIndex = 8;
            this.btnVerConsulta.Text = "Ver";
            this.btnVerConsulta.UseVisualStyleBackColor = true;
            this.btnVerConsulta.Click += new System.EventHandler(this.verDetalleCita_Click);
            // 
            // btnVerReceta
            // 
            this.btnVerReceta.Location = new System.Drawing.Point(600, 151);
            this.btnVerReceta.Name = "btnVerReceta";
            this.btnVerReceta.Size = new System.Drawing.Size(75, 23);
            this.btnVerReceta.TabIndex = 9;
            this.btnVerReceta.Text = "Ver Receta";
            this.btnVerReceta.UseVisualStyleBackColor = true;
            // 
            // btnEditarConsulta
            // 
            this.btnEditarConsulta.Location = new System.Drawing.Point(519, 151);
            this.btnEditarConsulta.Name = "btnEditarConsulta";
            this.btnEditarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarConsulta.TabIndex = 10;
            this.btnEditarConsulta.Text = "Editar";
            this.btnEditarConsulta.UseVisualStyleBackColor = true;
            this.btnEditarConsulta.Click += new System.EventHandler(this.EditarCita_Click);
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(41, 11);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(75, 23);
            this.regresar.TabIndex = 11;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // ListaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.btnEditarConsulta);
            this.Controls.Add(this.btnVerReceta);
            this.Controls.Add(this.btnVerConsulta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lbFiltroHasta);
            this.Controls.Add(this.lbFiltroDesde);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.listadoConsultas);
            this.Name = "ListaConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listadoConsultas;
        private System.Windows.Forms.ColumnHeader summary;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label lbFiltroDesde;
        private System.Windows.Forms.Label lbFiltroHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVerConsulta;
        private System.Windows.Forms.Button btnVerReceta;
        private System.Windows.Forms.Button btnEditarConsulta;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button regresar;
    }
}

