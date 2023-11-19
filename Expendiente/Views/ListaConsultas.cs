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
    public partial class ListaConsultas : Form
    {
        public ListaConsultas()
        {
            InitializeComponent();
            ListViewItem firstItem = new ListViewItem("Descripcion fake", 0);
            firstItem.SubItems.Add(DateTime.Now.ToString());

            ListViewItem secondItem = new ListViewItem("Descripcion fake 2", 0);
            secondItem.SubItems.Add(DateTime.Now.ToString());

            listadoConsultas.Items.Add(firstItem);
            listadoConsultas.Items.Add(secondItem);

            Array statuses = new[] { "Pendiente", "Cancelada" };
            cmbBoxSatuses.DataSource = statuses;


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaConsultas_Load(object sender, EventArgs e)
        {
            if (Session.GetCurrentUser().IsPatient())
            {
                btnEditarConsulta.Hide();
                cmbBoxSatuses.Hide();
                lblEstado.Hide();
                pnlNonPatientOptions.Hide();
            }

            if (Session.GetCurrentUser().IsNurse())
            { 
                btnRegresar.Hide();
            }
        }

        private void verDetalleCita_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new DetalleCita());
        }

        private void EditarCita_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new EditarCitas());
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Expediente());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaDePacientes());
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new EditarCitas());
        }

        private void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new EditarCitas());
        }

        private void btnVerConsulta_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new DetalleCita());
        }
    }
}
