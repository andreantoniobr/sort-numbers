using System;

namespace SortProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 7, 9, 6, 3, 9, 11, 4, 5, 3, 23
            };

            //1º versão usando metodo da classe padrao do C#
            Array.Sort(numbers);

            //2º versão: Usando classe pessoal SortUtility
            SortUtility.Sort(numbers);

            //Saida nas duas formas: [1, 3, 3, 4, 5, 6, 7, 9, 9, 11, 23]
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
            Console.ReadKey();
        }
    }
}
