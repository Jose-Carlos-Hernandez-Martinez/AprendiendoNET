/*
 * Ejercicio 8
 * Escribe un programa que declare 5 variables de tipo char. A continuación, crea
 * otra variable como cadena de caracteres y asígnale como valor la concatenación 
 * de las anteriores 5 variables. Por último, muestra la cadena de caracteres
 * por pantalla ¿Qué problemas te encuentras? ¿cómo lo has solucionado?
*/

using System;

namespace AprendiendoNET._02_Variables
{
    class Ejercicio08
    {
        public static void Ejecutar()
        {
            char myCharOne =   'a';
            char myCharTwo =   'e';
            char myCharThree = 'i';
            char myCharFour =  'o';
            char myCharFive =  'u';

            string myString = $"{myCharOne}{myCharTwo}{myCharThree}{myCharFour}{myCharFive}";

            Console.WriteLine($"My string : {myString}");

        }
    }
}
