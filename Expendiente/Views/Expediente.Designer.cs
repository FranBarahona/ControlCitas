
namespace ControlCitas
{
    partial class Expediente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regresar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnContactoEmergencia = new System.Windows.Forms.Button();
            this.btnAntecedentes = new System.Windows.Forms.Button();
            this.btnHistorialConsultas = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(266, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(266, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Correo.Location = new System.Drawing.Point(121, 104);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(57, 20);
            this.Correo.TabIndex = 9;
            this.Correo.Text = "Correo";
            this.Correo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(119, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expendiente.Properties.Resources.images2;
            this.pictureBox1.Location = new System.Drawing.Point(585, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 132);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(22, 13);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(95, 31);
            this.regresar.TabIndex = 20;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(585, 219);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 29);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.editar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnContactoEmergencia);
            this.flowLayoutPanel1.Controls.Add(this.btnAntecedentes);
            this.flowLayoutPanel1.Controls.Add(this.btnHistorialConsultas);
            this.flowLayoutPanel1.Controls.Add(this.btnNuevaConsulta);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 320);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 83);
            this.flowLayoutPanel1.TabIndex = 22;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnContactoEmergencia
            // 
            this.btnContactoEmergencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContactoEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnContactoEmergencia.Location = new System.Drawing.Point(3, 3);
            this.btnContactoEmergencia.Name = "btnContactoEmergencia";
            this.btnContactoEmergencia.Size = new System.Drawing.Size(165, 77);
            this.btnContactoEmergencia.TabIndex = 7;
            this.btnContactoEmergencia.Text = "Contacto de emergencia ";
            this.btnContactoEmergencia.UseVisualStyleBackColor = true;
            this.btnContactoEmergencia.Click += new System.EventHandler(this.btnContactoEmergencia_Click);
            // 
            // btnAntecedentes
            // 
            this.btnAntecedentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAntecedentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnAntecedentes.Location = new System.Drawing.Point(174, 3);
            this.btnAntecedentes.Name = "btnAntecedentes";
            this.btnAntecedentes.Size = new System.Drawing.Size(165, 77);
            this.btnAntecedentes.TabIndex = 6;
            this.btnAntecedentes.Text = "Antecedentes";
            this.btnAntecedentes.UseVisualStyleBackColor = true;
            this.btnAntecedentes.Click += new System.EventHandler(this.btnAntecedentes_Click);
            // 
            // btnHistorialConsultas
            // 
            this.btnHistorialConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorialConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnHistorialConsultas.Location = new System.Drawing.Point(345, 3);
            this.btnHistorialConsultas.Name = "btnHistorialConsultas";
            this.btnHistorialConsultas.Size = new System.Drawing.Size(165, 77);
            this.btnHistorialConsultas.TabIndex = 5;
            this.btnHistorialConsultas.Text = "Historial de consultas";
            this.btnHistorialConsultas.UseVisualStyleBackColor = true;
            this.btnHistorialConsultas.Click += new System.EventHandler(this.btnHistorialConsultas_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnNuevaConsulta.Location = new System.Drawing.Point(516, 3);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(165, 77);
            this.btnNuevaConsulta.TabIndex = 4;
            this.btnNuevaConsulta.Text = "Nueva consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(585, 254);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(129, 30);
            this.Guardar.TabIndex = 23;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Expediente";
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.Expediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnContactoEmergencia;
        private System.Windows.Forms.Button btnAntecedentes;
        private System.Windows.Forms.Button btnHistorialConsultas;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Button Guardar;
    }
}

