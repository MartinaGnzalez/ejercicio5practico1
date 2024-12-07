using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz(3, 3);
            Matriz matriz2 = new Matriz(3, 3);

            ImprimirMatriz(matriz1);
            Console.WriteLine();
            ImprimirMatriz(matriz2);

            Matriz resultado = matriz1.sumarMatrices(matriz2);

            Console.WriteLine("Resultado de la suma:");
            ImprimirMatriz(resultado);
        }

        static void ImprimirMatriz(Matriz m)
        {
            for (int i = 0; i < m.filas; i++)
            {
                for (int j = 0; j < m.columnas; j++)
                {
                    Console.Write(m.matrizInterna[i, j] + "");

                }
                Console.WriteLine();
            }
        }
    }
}
        
