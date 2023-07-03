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

            // Ahora haremos lo mismo pero con arreglos bidimensionales.

            Console.WriteLine("-------------------------------------------");

            int[][,] jaggedBi = new int[2][,] // Arreglo bidimensional con 2 valores.
            {
                new int[,] // Primer array.
                {
                    { 8, 6 },
                    { 4, 2 },
                    { 3, 7 }
                },
                new int[,] // Segundo array.
                {
                    { 8, 2, 1 },
                    { 7, 5, 3 }
                }
            };

            // Se debe recorrer un array por filas y columnas mediante un ciclo for.

            for (int i = 0; i < jaggedBi.Length; i++) // Filas.
            {
                for (int j = 0; j < jaggedBi[i].GetLength(0); j++) // Columnas.
                {
                    for (int k = 0; k < jaggedBi[i].GetLength(1); k++) // Array combinado.
                    {
                        Console.WriteLine($"{jaggedBi[i][j,k]}"); // Se crea un jagged array con arrays bidimensionales.
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}