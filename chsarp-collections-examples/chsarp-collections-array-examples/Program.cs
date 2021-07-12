using System;

namespace chsarp_collections_array_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /**** Declaração de Arrays ****/

            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Declaração de array através de seus VALORES.
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            // Forma simplificada de declarar o mesmo array.
            //string[] aulas =
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Declaração de array através de seus TAMANHO.
            string[] aulas = new string[3];

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            /**** Acessando itens do Arrays ****/
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            /**** Declaração de Arrays ****/

            // Modo Errado. Deste modo há alteração apenas na variável.
            // O array permanece com o mesmo texto inicial, porque foi atribuído o valor e não a referência.
            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            // Modo Correto.
            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            /**** Operações com Arrays ****/

            // 1. Encontrando o primeiro item que satisfaz a condição.
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));

            // 2. Encontrando o último item que satisfaz a condição.
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            // 3. Reverter a ordem do array.
            Array.Reverse(aulas);
            Imprimir(aulas);

            // 4. Redimensionar um array.
            Array.Resize(ref aulas, 2); // Novo Tamanho = 2
            Imprimir(aulas);

            Array.Resize(ref aulas, 3); // Novo Tamaho = 3
            Imprimir(aulas);

            // 5. Ordenar um array.
            Array.Sort(aulas);
            Imprimir(aulas);

            // 6. Copiar um array.
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            // 7. Clonar um array.
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            // 8. Limpar um array.
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
            Console.WriteLine();
        }
    }
}
