using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
        int fila = Convert.ToInt32(FilatextBox.Text);
            int columna = Convert.ToInt32(ColumnatextBox.Text);
            int[,] Matriz = new int[fila, columna];
            //Agregar numeros aleatoros
            Random numeros = new Random();  

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Matriz[i, j] = numeros.Next(1, 100);

                }
            }

               //ingresar los datos al datagridview.
            dataGridView.ColumnCount = columna;
            dataGridView.RowCount = fila;

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Matriz[i, j].ToString();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilatextBox.Clear();
            ColumnatextBox.Clear();
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

