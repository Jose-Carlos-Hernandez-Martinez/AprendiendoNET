/*
 * Ejercicio 4
 * Realiza un conversor de euros a pesos. La cantidad en euros que se quiere
 * convertir deberá estar almacenada en una variable.
*/
using System;

namespace AprendiendoNET._02_Variables
{
    class Ejercicio04
    {
        public static void Ejecutar()
        {

            double valorEuro = 22.5;
            int cantidadEuro = 10;

            double cantidadFinalPesos = valorEuro * cantidadEuro;

            Console.WriteLine($"Valor del euro {valorEuro}");

            Console.WriteLine($"La cantidad de {cantidadEuro} euros a pesos es {cantidadFinalPesos}");
        }
    }
}
