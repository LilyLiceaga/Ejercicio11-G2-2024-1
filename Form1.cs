using System;
using System.Collections;
using System.Windows.Forms;
using ClassLibrary_Clientes_Ejercicio11;

namespace Ejercicio10_G2_2024_1
{
    public partial class Form1 : Form 
    {
        ArrayList personas;
        public Form1()
        {
            InitializeComponent();
            personas = new ArrayList();
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            personas.Add(new Cliente(txtbNombre.Text, txtbTelefono.Text, byte.Parse(txtbEdad.Text), txtbDireccion.Text) );
        }
    }
}
