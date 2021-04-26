using System;

namespace AT_Klevtsov_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];

            Random rand = new Random();

            Console.WriteLine("Массив, заполненный случайным образом:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(0, 100);
                Console.Write(" " + A[i]);
            }
            Console.WriteLine();
            Console.WriteLine(new String('-', 50));

            int temp;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного по возрастанию массива");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" " + A[i]);
            }
            Console.WriteLine();
            Console.WriteLine(new String('-', 50));
            Console.ReadLine();

        }
    }
}
