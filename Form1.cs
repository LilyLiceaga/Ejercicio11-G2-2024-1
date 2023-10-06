﻿using System;
using System.Collections;
using System.Windows.Forms;
using ClassLibrary_Clientes_Ejercicio11;

namespace Ejercicio10_G2_2024_1
{
    public partial class Form1 : Form 
    {
        ArrayList personas;
        private int indice;
        public int Indice 
        { 
            get => indice;
            set
            { 
                if(personas.Count > 0 && value < personas.Count)
                {
                    indice = value;
                }
                else
                {
                    indice = 0;
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            personas = new ArrayList();
        }


        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            personas.Add(new Cliente(txtbNombre.Text, txtbTelefono.Text, byte.Parse(txtbEdad.Text), txtbDireccion.Text) );
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente persona = (Cliente)personas[Indice++];

                txtbNombre.Text = persona.Nombre;
                txtbTelefono.Text = persona.Telefono;
                txtbEdad.Text = persona.Edad.ToString();
                txtbDireccion.Text = persona.Direccion;
            }
            catch(NullReferenceException error)
            {
                MessageBox.Show("Error: Debes agregar al menos una persona");
            }
            catch(IndexOutOfRangeException error)
            {
                MessageBox.Show("Error: Debes agregar al menos una persona");
            }
        }
    }
}
