﻿using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercícios Operadores ",ExerciciosOperadores.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar},
                {"Estrutura Switch - Estruturas de Controle",EstruturaSwitch.Executar},
                {"Estrutura While e For - Estruturas de Controle",EstruturaWhileEFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle",EstuturaForEach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Métodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Exercicios Métodos com Retorno - Classes e Métodos",ExerciciosMetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos",MetodosEstaticos.Executar},
                {"Exercicios Get e Set 1",exercicioGeteSet1.Executar},
                {"Exercicios Get e Set 2",exercicioGeteSet2.Executar},
                {"Exercicios Get e Set 3",exercicioGeteSet3.Executar},
                {"Coleções Queue",ColecoesQueue.Executar},
                {"Coleções Stack",ColecoesStack.Executar},
                //POO
                {"Exercicio Polimorfismo",ExercicioPolimorfismo.Executar},
                {"Abstract - POO",Abstract.Executar}
            }); ;

            central.SelecionarEExecutar();
        }
    }
}