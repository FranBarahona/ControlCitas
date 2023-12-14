using Contactos_De_Emergencia;
using Expendiente.Models;
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
    public partial class Expediente : Form
    {
        private InMemoryUsersRepository UsersRepository = new InMemoryUsersRepository();
        private User user;
        private int idUser;
        public Expediente(int idUser)
        {
            this.user = UsersRepository.FindById(idUser);
            this.idUser = idUser;
            InitializeComponent();
            initialize();

        }

        private void initialize()
        {
            activeTextBoxs(false);

            this.textBox1.Text = user.Name;
            this.textBox2.Text = user.Email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void antecendentes_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Antecedentes());
        }

        private void historial_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            if (Session.GetCurrentUser().IsPatient())
            {
                ControladorNavegacion.MostrarFormulario(new AgendarCita());
                return;
            }

            if (Session.GetCurrentUser().IsDoctor())
            {
                ControladorNavegacion.MostrarFormulario(new ListaConsultas());
                return;
            }

            ControladorNavegacion.MostrarFormulario(new ListaDePacientes());
        }

        private void editar_Click(object sender, EventArgs e)
        {
            activeTextBoxs(true);
            Guardar.Show();

        }

        private void contactosEmergencia_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ContactosDeEmergencia());
        }

        private void Expediente_Load(object sender, EventArgs e)
        {
            Guardar.Hide();
            if(Session.GetCurrentUser().IsPatient())
            {
                btnNuevaConsulta.Hide();
                //btnEditar.Hide();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Antecedentes());
        }

        private void btnHistorialConsultas_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ListaConsultas());
        }

        private void btnContactoEmergencia_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new ContactosDeEmergencia());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var nombre = this.textBox1.Text;
            var correo = this.textBox2.Text;
            UsersRepository.Update(this.idUser,nombre,correo);
            RecargarInformacion();
            Guardar.Hide();
            activeTextBoxs(false);
        }

        private void RecargarInformacion()
        {
            // Puedes hacer una nueva consulta para obtener la información actualizada desde la base de datos
            var usuarioActualizado = UsersRepository.FindById(this.idUser);

            // Actualiza los campos en la interfaz de usuario con la información recargada
            this.textBox1.Text = usuarioActualizado.Name;
            this.textBox2.Text = usuarioActualizado.Email;
        }

        private void activeTextBoxs(bool isActive)
        {
            this.textBox1.Enabled = isActive;
            this.textBox2.Enabled = isActive;
        }
    }
}
