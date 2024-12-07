using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5practico1
{
    internal class Matriz
    {
        public int filas;
        public int columnas;
        public int[,] matrizInterna;

        public Matriz(int nuevofilas, int nuevocolumnas)
        {
            filas = nuevofilas;
            columnas = nuevocolumnas;
            matrizInterna = new int[filas, columnas];
            rellenarMatrizConValoresAleatorios();

        }

        private void rellenarMatrizConValoresAleatorios()
        {
            Random numero = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {

                    matrizInterna[i, j] = numero.Next(9,205);
                }
            }
        }
        public Matriz sumarMatrices (Matriz nueva) 
        { 
            if (filas != nueva.filas || columnas != nueva.columnas)
            {
                throw new Exception("Las matrices deben tener las misma dimensiones para poder sumarlas.");
            }

            Matriz resultado = new Matriz(filas, columnas);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0;j < columnas; j++)
                {
                    resultado.matrizInterna[i, j] = this.matrizInterna[i, j] + nueva.matrizInterna[i, j];
                }
            }
            return resultado;

           
        }
    }
}



