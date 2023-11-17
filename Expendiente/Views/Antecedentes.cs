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
    public partial class Antecedentes : Form
    {
        public Antecedentes()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new AgregarAntecedentes());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Expediente());
        }
    }
}
