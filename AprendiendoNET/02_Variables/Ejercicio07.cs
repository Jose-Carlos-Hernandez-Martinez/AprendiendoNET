/*
 * Ejercicio 7
 * Escribe un programa que declare variables de tipo char y de tipo String. Intenta
 * mostrarlas por pantalla todas juntas en la misma línea y con una sola sentencia
 * de C#
 * 
*/

using System;

namespace AprendiendoNET._02_Variables
{
    class Ejercicio07
    {
        public static void Ejecutar()
        {
            char myChar = 'a';
            string myString = "Hola";

            Console.WriteLine($"{myString} {myChar}");
        }
    }
}

