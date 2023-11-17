// Código en la clase ControladorNavegacion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class ControladorNavegacion
{
    private static Panel panelContenedor;

    public static void Inicializar(Panel contenedor)
    {
        panelContenedor = contenedor;
    }

    public static void MostrarFormulario(Form formulario)
    {
        LimpiarContenedor();
        formulario.TopLevel = false;
        formulario.FormBorderStyle = FormBorderStyle.None;
        formulario.Dock = DockStyle.Fill;
        panelContenedor.Controls.Add(formulario);
        formulario.Show();
    }

    private static void LimpiarContenedor()
    {
        foreach (Control control in panelContenedor.Controls)
        {
            if (control is Form)
            {
                ((Form)control).Close();
            }
        }
        panelContenedor.Controls.Clear();
    }
}