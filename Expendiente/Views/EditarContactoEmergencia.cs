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
    public partial class EditarContactoEmergencia : Form
    {
        public EditarContactoEmergencia()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ContactosDeEmergencia());
        }
    }
}
