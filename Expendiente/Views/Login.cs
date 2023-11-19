
using Expendiente.Models;
using Expendiente.Repositories;
using PruebaForm;
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
    public partial class Login : Form
    {
        private InMemoryUsersRepository UsersRepository = new InMemoryUsersRepository();
        private string SessionError = string.Empty;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // TODO: Mover esta logica a un mejor lugar. Se dejo aqui con el proposito de realizar la demo.

            if (txtBoxEmail.Text == string.Empty) {
                SessionError = "El correo no puede estar vacio";
                lblSessionError.Text = SessionError;
                return;
            }
            
            if (txtBoxPassword.Text == string.Empty) {
                SessionError = "La contraseña no puede estar vacio";
                lblSessionError.Text = SessionError;
                return;
            }

            User user = UsersRepository.FindByEmail(txtBoxEmail.Text);

            if (user == null || !user.IsValidPassword(txtBoxPassword.Text))
            {
                SessionError = "Credenciales Incorrectas";
                lblSessionError.Text = SessionError;
                return;
            }

            Session.Start(user);
            if (Session.GetCurrentUser().IsDoctor())
            {
                ControladorNavegacion.MostrarFormulario(new InicioDoc());
                return;
            }

            if (Session.GetCurrentUser().IsNurse())
            {
                ControladorNavegacion.MostrarFormulario(new ListaConsultas());
                return;
            }

            ControladorNavegacion.MostrarFormulario(new AgendarCita());
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
