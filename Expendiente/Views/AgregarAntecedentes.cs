﻿using System;
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
    public partial class AgregarAntecedentes : Form
    {
        public AgregarAntecedentes()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Antecedentes());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarAntecedentes_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ControladorNavegacion.MostrarFormulario(new Expediente());
        }
    }
}
