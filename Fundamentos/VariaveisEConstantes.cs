using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {

            //variavel
            double raio = 1.3;

            //constante
            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine($"A área total é de: {area}");


        }
    }
}
