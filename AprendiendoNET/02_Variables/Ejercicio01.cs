/*
 *
 * Ejercicio 1
 * Escribe un programa en el que se declaren las variables enteras x e y. Asígnales
 * los valores 144 y 999 respectivamente. A continuación, muestra por pantalla
 * el valor de cada variable, la suma, la resta, la división y la multiplicación.
*/


using System;


namespace AprendiendoNET._02_Variables
{
    class Ejercicio01
    {
        public static void Ejecutar()
        {
            int x;
            int y;

            x = 144;
            y = 999;

            Console.WriteLine($"El valor de x : {x}");
            Console.WriteLine($"El valor de y : {y}");
            Console.WriteLine($"Suma  : {x} + {y} =  {x + y}");
            Console.WriteLine($"Resta : {x} - {y} = {x - y}");
            Console.WriteLine($"División : {x} / {y} = {(double) x / y}");
            Console.WriteLine($"Multiplicación : {x} * {y} = {x * y}");
        }
    }
}
