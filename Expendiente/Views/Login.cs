﻿
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rol = "cliente";
            if (rol == "cliente")
            {
            ControladorNavegacion.MostrarFormulario(new AgendarCita());

            }else
            {
                ControladorNavegacion.MostrarFormulario(new ListaConsultas());
            }
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
