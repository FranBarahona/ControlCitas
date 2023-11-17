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
    public partial class AgendarCita : Form
    {
        public AgendarCita()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agenda_Click(object sender, EventArgs e)
        {
            ConfirmacionCita confirmacion = new ConfirmacionCita();
            confirmacion.Show();
        }

        private void verPerfil_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Expediente());
        }
    }
}
