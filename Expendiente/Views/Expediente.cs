using Contactos_De_Emergencia;
using Expendiente.Repositories;
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
            if (Session.GetCurrentUser().IsPatient())
            {
                ControladorNavegacion.MostrarFormulario(new AgendarCita());
                return;
            }

            if (Session.GetCurrentUser().IsDoctor())
            {
                ControladorNavegacion.MostrarFormulario(new ListaConsultas());
                return;
            }

            ControladorNavegacion.MostrarFormulario(new ListaDePacientes());
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

        private void Expediente_Load(object sender, EventArgs e)
        {
            if(Session.GetCurrentUser().IsPatient())
            {
                btnNuevaConsulta.Hide();
                btnEditar.Hide();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Antecedentes());
        }

        private void btnHistorialConsultas_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void btnContactoEmergencia_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ContactosDeEmergencia());
        }
    }
}
