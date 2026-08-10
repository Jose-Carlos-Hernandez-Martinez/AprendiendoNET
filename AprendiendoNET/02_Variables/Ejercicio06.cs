/*
 * Ejercicio 6
 * Escribe un programa que calcule el total de una factura a partir de la base
 * imponible (precio sin IVA). La base imponible estará almacenada en una
 * variable.
*/

using System;

namespace AprendiendoNET._02_Variables
{
    class Ejercicio06
    {
        public static void Ejecutar()
        {
            const double tasaIva = 0.16;
            Console.Write("Ingrese el precio (precio sin IVA): ");

            if (double.TryParse(Console.ReadLine(), out double baseImponible))
            {
                double montoIva = baseImponible * tasaIva;
                double totalFactura = baseImponible + montoIva;

                Console.WriteLine("\n--- DESGLOSE DE FACTURA ---");
                Console.WriteLine($"Base Imponible (Sin IVA) : ${baseImponible:F2}");
                Console.WriteLine($"Monto de IVA (16%)       : ${montoIva:F2}");
                Console.WriteLine($"Total Factura            : ${totalFactura:F2}");
            }
            else
            {
                Console.WriteLine("ERROR : La entrada no es la correcta");
            }
        }
    }
}
