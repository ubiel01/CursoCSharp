using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class exercicioGeteSet1
    {
        public class Pessoa
        {
            string nome;
            double altura;
            DateTime dataNascimento;


            public string Nome { get; set; }
            public double Altura { get; set; }
            public DateTime DataNascimento
            {


                get
                {
                    return dataNascimento;
                }

                set
                {
                    dataNascimento = value;


                }
            }

            public void ImprimirDados()
            {
                Console.WriteLine($"{Nome}, {Altura}, {DataNascimento}");
            }
            public int CalcularIdade()
            {
                return DateTime.Today.Year - DataNascimento.Year;
            }



        }

        public static void Executar()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Larissa";
            pessoa.Altura = 1.70;
            pessoa.DataNascimento = new DateTime(2006, 5, 5);
            pessoa.CalcularIdade();
            pessoa.ImprimirDados();
            int idade = pessoa.CalcularIdade();
            Console.WriteLine(idade);
        }
    }
}

