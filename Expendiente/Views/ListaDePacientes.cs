using ControlCitas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos_De_Emergencia
{
    public partial class ListaDePacientes : Form
    {
        BindingList<String> strings = new BindingList<String>();
        public ListaDePacientes()
        {
            InitializeComponent();
            strings.Add("Hola");
            listBox1.DataSource = strings;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Expediente());
        }

        private void ListaDePacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
