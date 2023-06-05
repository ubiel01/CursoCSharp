using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicios
    {
        public static void Executar()
        {
            /* Exercicio 1 */
            
            Console.WriteLine("Nota do 1º Bimestre");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota do 2º Bimestre");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota da 3º Bimestre");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sua media final é {(n1+n2+n3)/3}");
             

            /* Exercicio 2 */
            
            Console.WriteLine("Nota do 1º Bimestre");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota do 2º Bimestre");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Sua média final é {((n1*3.5)+(n2*7.5))/11}");


            /* Exercicio 3 */
            
            Console.WriteLine("Me informe seu número de funcionario:");
            int nf = int.Parse(Console.ReadLine());

            Console.WriteLine("Me informe suas horas trabalhadas:");
            int ht = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe quanto voce recebe por hora:");
            double rh = double.Parse(Console.ReadLine());

            Console.WriteLine($"Número de Funcionario: {nf}\nSeu salário atual: {ht*rh}");
            

        }
    }
}
