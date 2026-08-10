/*
 * Ejercicio 5
 * Realiza un conversor de pesos a euros. La cantidad en pesos que se quiere
 * convertir deberá estar almacenada en una variable.
*/

using System;

namespace AprendiendoNET._02_Variables
{
    class Ejercicio05
    {
        public static void Ejecutar()
        {
            const double valorEuro = 22.5;

            if (double.TryParse(Console.ReadLine(), out double cantidadPesos))
            {
                double cantidadEuros = cantidadPesos / valorEuro;

                Console.WriteLine($"La cantidad de {cantidadPesos:N2} pesos a euros es: {cantidadEuros:N4}");
            }
            else
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
            }
        }
    }
}
