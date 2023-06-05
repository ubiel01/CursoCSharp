using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodosComRetorno
    {
        /*class ExecicioDolareReal {
            public double ConversaoReD(double r) 
            {
                return r * 4.95;
            } 
        }
        public static void Executar()
        {
            Console.WriteLine("Qual valor o senhor deseja converter?");
            double real = double.Parse(Console.ReadLine());

            var exercicioDolareReal = new ExecicioDolareReal();

            var resultado = exercicioDolareReal.ConversaoReD(real);

            Console.WriteLine($"{resultado}");
          
        }
 */
        class ExerciciosTemp
        {
            public double ConversaoCeF(double c)
            {
                return c * 1.8 + 32;
            }
        }
        public static void Executar()
        {

            Console.WriteLine("Quantos graus C° o senhor quer converter para F°?");
            double celsius = double.Parse(Console.ReadLine());

            var exercicioTemp = new ExerciciosTemp();

            var resultado = exercicioTemp.ConversaoCeF(celsius);

            Console.WriteLine($"{resultado}");

        }
    }
}

