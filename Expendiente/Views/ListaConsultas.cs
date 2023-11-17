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

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
