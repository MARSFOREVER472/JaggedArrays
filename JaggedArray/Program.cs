using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arrayJagged = new int[3][] // Matriz Indentada.
            {
                new int[4] { 1, 2, 3, 4 }, // Array 0 con 4 valores.
                new int[3] { 5, 6, 7 }, // Array 1 con 3 valores.
                new int[3] { 8, 9, 10 } // Array 2 con 3 valores.
            };

            for (int i = 0; i < arrayJagged.Length; i++) // Arrays divididos en filas.
            {
                for (int j = 0; j < arrayJagged[i].Length; j++) // Arrays divididos en columnas, que también se combinan por filas.
                {
                    Console.WriteLine($"{arrayJagged[i][j]} "); // Se crea una matriz indentada con arrays unidimensionales.
                }
                Console.WriteLine();
            }
        }
    }
}