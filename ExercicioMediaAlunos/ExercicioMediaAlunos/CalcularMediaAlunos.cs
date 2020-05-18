using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMediaAlunos
{
    public class CalcularMediaAlunos<T>
    {
        public T calcularMedia(T nota1, T nota2)
        {

            double numero1 = 0;
            double numero2 = 0;
            object resultadoFinal = 0;

            string string1 = Convert.ToString(nota1);
            string string2 = Convert.ToString(nota2);

            bool testeTipo = double.TryParse(string1, out numero1).Equals(double.TryParse(string2, out numero2));

            if (testeTipo == false) { 

            
            }
            return resultadoFinal = (object) nota1 + nota2;
        }
       
    }
}
