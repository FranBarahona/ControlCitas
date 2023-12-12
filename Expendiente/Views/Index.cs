using Expendiente.conn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCitas
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.Load += FormPrincipal_Load;
            ControladorNavegacion.Inicializar(panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            ControladorNavegacion.MostrarFormulario(new Login());
            // Crear una instancia del formulario secundario
         // Login login = new Login();
            

            // Limpiar el panelContenedor antes de agregar un nuevo control
          //  panel1.Controls.Clear();

           // login.TopLevel = false;
           // login.FormBorderStyle = FormBorderStyle.None; // Quitar el borde del formulario secundario
           // login.Dock = DockStyle.Fill; // Rellenar el panelContenedor
           // panel1.Controls.Add(login);

            // Mostrar el formulario secundario
           // login.Show();
        }

    }
}
