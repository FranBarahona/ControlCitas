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
    public partial class DetalleCita : Form
    {
        public DetalleCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datFecha_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxDiagnostico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void DetalleCita_Load(object sender, EventArgs e)
        {
            dtPickerFechaConsulta.Enabled = false;
            if (Session.GetCurrentUser().IsPatient())
            {
                txtBoxPaciente.Enabled = false;
                txtBoxPeso.Enabled = false;
                txtBoxTemp.Enabled = false;
                txtBoxDiagnostico.Enabled = false;
                txtBoxReceta.Enabled = false;
            }
        }
    }
}
