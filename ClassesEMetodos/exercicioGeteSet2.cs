using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class exercicioGeteSet2
    {

        public class Aluno
        {
            int n1;
            int n2;
            int n3;

            public int N1 { get; set; }
            public int N2 { get; set; }
            public int N3 { get; set; }

            public int Media()
            {
                return (N1 + N2 + N3) / 3;
            }
            public void ImprimirDados()
            {
                Console.WriteLine($"{N1}, {N2}, {N3}");
                Console.WriteLine(Media());
            }



        }


        public static void Executar()
        {
            var aluno = new Aluno();
            aluno.N1 = 10;
            aluno.N2 = 10;
            aluno.N3 = 10;
            aluno.ImprimirDados();
        }
    }
}