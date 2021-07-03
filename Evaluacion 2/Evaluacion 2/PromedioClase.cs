using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2
{
    class PromedioClase
    {
        private string nombreEstudiante;
        private decimal numeroCuenta;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;

        public string NombreEstudiante { get; set; }
        public decimal NumeroCuenta { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota4 { get; set; }

        public PromedioClase() { }

        public PromedioClase (string _NombreEstudiante, int _NumeroCuenta)
        {
            NombreEstudiante = _NombreEstudiante;
            NumeroCuenta = _NumeroCuenta;
        }
        public PromedioClase (string _NombreEstudiante, decimal _NumeroCuenta, decimal _Nota1, decimal _Nota2, decimal _Nota3, decimal _Nota4)
        {
            NombreEstudiante = _NombreEstudiante;
            NumeroCuenta = _NumeroCuenta;
            Nota1 = _Nota1;
            Nota2 = _Nota2;
            Nota3 = _Nota3;
            Nota4 = _Nota4;
        }
        public decimal devolverPromedio()
        {
            decimal calcular;
            calcular = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return calcular;
        }

        public decimal AprobadoReprobado()
        {
            decimal calcular= devolverPromedio();

            if (calcular >= 70) 
            {
                System.Windows.Forms.MessageBox.Show(" usted esta Aprobado su promedio es de ");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(" usted esta reprobado su promedio es de ");
            }
            return calcular ;
        }
    }
}
