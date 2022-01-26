using System;

namespace _1_ArreglosVectores_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar vectores
            //[] - > Vector
            // [,] - > Matriz 2D
            // [,,] - > Matriz 3D
            // [,,,] - > Matriz 4D
            int[] distancias = new int[10];


            // Asignar Valores
            distancias[0] = 3;
            distancias[1] = 2;
            distancias[2] = 6;
            distancias[3] = 9;
            distancias[4] = 5;
            distancias[5] = 1;
            distancias[6] = 2;
            distancias[7] = 3;
            distancias[8] = 5;
            distancias[9] = 6;


            //Acceder a los valores
            Console.WriteLine(distancias[3]);
            Console.ReadLine();

            //Recorrer valores
            for (int indice = 0; indice<9;indice++)
            {
                Console.WriteLine(distancias[indice]);
            }
        }
    }
}
