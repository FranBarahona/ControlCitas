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
    public partial class ContactosDeEmergencia : Form
    {
        public ContactosDeEmergencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void editarDatosContacto_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new EditarContactoEmergencia());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Expediente());
        }
    }
}
