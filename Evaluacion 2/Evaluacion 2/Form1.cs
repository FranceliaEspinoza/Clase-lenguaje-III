using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            PromedioClase Promedio = new PromedioClase();
            Promedio.NombreEstudiante = NombretextBox.Text;
            Promedio.NumeroCuenta = Convert.ToDecimal(NumeroCuentatextBox.Text);
            Promedio.Nota1 = Convert.ToDecimal(Nota1textBox.Text);
            Promedio.Nota2 = Convert.ToDecimal(Nota2textBox.Text);
            Promedio.Nota3 = Convert.ToDecimal(Nota3textBox.Text);
            Promedio.Nota4 = Convert.ToDecimal(Nota4textBox.Text);

            MessageBox.Show(Convert.ToString(Promedio.AprobadoReprobado()));

            CalificacioneslistBox.Items.Add(NombretextBox.Text + " - " + NumeroCuentatextBox.Text + " - " + Promedio.devolverPromedio());
            NombretextBox.Clear();
            NumeroCuentatextBox.Clear();
            Nota1textBox.Clear();
            Nota2textBox.Clear();
            Nota3textBox.Clear();
            Nota4textBox.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            NumeroCuentatextBox.Clear();
            Nota1textBox.Clear();
            Nota2textBox.Clear();
            Nota3textBox.Clear();
            Nota4textBox.Clear();
            CalificacioneslistBox.Items.Clear();
            MessageBox.Show("Todos los datos han sido eliminados");
        }
        private void salirbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
 