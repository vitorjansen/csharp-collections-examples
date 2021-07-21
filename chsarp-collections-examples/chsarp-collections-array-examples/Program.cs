using System;
using System.Collections.Generic;
using System.Linq;

namespace chsarp_collections_array_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /**** Declaração de List<> ****/

            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Declaração de List através de seus VALORES.
            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            // Declaração de List vazia
            List<string> aulas = new List<string>();


            /**** Operações com List ****/

            // Adicionar itens a uma lista
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);


            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A última aula é " + aulas.Last());


        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            //Console.WriteLine();

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}
