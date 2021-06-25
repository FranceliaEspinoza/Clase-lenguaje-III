using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Clase_lenguaje_III
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            edadTexBox.Clear();
            DatoscomboBox.Items.Clear();
            MessageBox.Show("Todos los datos han sido eliminados");
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            DatoscomboBox.Items.Add(NombretextBox.Text + " - " + edadTexBox.Text);
            MessageBox.Show(NombretextBox.Text + " - " + edadTexBox.Text + " agregados");
            NombretextBox.Clear();
            edadTexBox.Clear();
        }

        private void Ascbutton_Click(object sender, EventArgs e)
        {
             DatoscomboBox.Sorted = true;
            MessageBox.Show("DatoscomboBox ordenados ascendentemente");                    
        }

        private void descbutton_Click(object sender, EventArgs e)
        {           
            DatoscomboBox.Sorted = false;
            ArrayList Francelia = new ArrayList();
            Francelia.AddRange(DatoscomboBox.Items);
            Francelia.Reverse();
            DatoscomboBox.Items.Clear();
            for (int i = 0; i < Francelia.Count; i ++)
            {
                DatoscomboBox.Items.Add(Francelia[i]);
            }
            MessageBox.Show("DatoscomboBox ordenados descendentemente");
        }
    }

}



























//List<string> Datos = new List<string>();
//Datos.AddRange(Nombre);
//Datos.AddRange(edad);
//Resultado.Add(Nombre, Convert.ToString(edad));
//DatoscomboBox.Items.Add(Nombre);
// List<string> Nombre = new List<string>(edad);
//string.Join(Nombre.Length + edad.Length);


//string[] Datos = new string[Nombre.Length + edad.Length];

//Array.Sort(Nombre);
//Array.Reverse(Nombre);
//string[] Datos = Nombre.Union(edad).ToArray();
