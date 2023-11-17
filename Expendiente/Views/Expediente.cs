using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCitas
{
    public partial class Expediente : Form
    {
        public Expediente()
        {
            InitializeComponent();
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.textBox4.Enabled = false;
            this.textBox5.Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void antecendentes_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Antecedentes());
        }

        private void historial_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new AgendarCita());
        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox3.Enabled = true;
            this.textBox4.Enabled = true;
            this.textBox5.Enabled = true;
        }

        private void contactosEmergencia_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ContactosDeEmergencia());
        }
    }
}
