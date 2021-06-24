using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string[] Nombre = new string [] {NombretextBox.Text};
            int[] edad = new int[] {Convert.ToInt32(edadTexBox.Text)};


            foreach (var items in Nombre)
            {

                DatoscomboBox.Items.Add(items);

           }
            foreach (var items in edad)
            {

                DatoscomboBox.Items.Add(items);
            }

        }

        private void Ascbutton_Click(object sender, EventArgs e)
        {
            string[] Nombre = new string[] { NombretextBox.Text };
            int[] edad = new int[] { Convert.ToInt32(edadTexBox.Text) };


            foreach (var items in Nombre)
            {

                DatoscomboBox.Sorted = true; 

            }
           
        }

        private void descbutton_Click(object sender, EventArgs e)
        {
            string[] Nombre = new string[] { NombretextBox.Text };
            //int[] edad = new int[] { Convert.ToInt32(edadTexBox.Text) };

            Array.Sort(Nombre);
            Array.Reverse(Nombre);

            foreach (var items in Nombre)
            {

                DatoscomboBox.Items.AddRange(Nombre);

            }


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
