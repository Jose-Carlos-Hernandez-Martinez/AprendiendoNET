
using System;

namespace AprendiendoNET
{
    class Program
    {
        static void Main(string[] args) 
        {
            string[] caps = {   "01_SalidaDeDatos", 
                                "02_Variables", 
                                "03_LecturaDeNumeros", 
                                "04_SentenciaCondicional_if_switch", 
                                "05_Bucles", 
                                "06_NumerosAleatorios",
                                "07_Arrays",
                                "08_Funciones",
                                "09_POO",
                                "10_ColeccionesYDiccionarios",
                                "11_ManejoDeFIcheros",
                                "12_GestionDeExcepciones",
                                "13_DesarrolloWeb_AspNetCore",
                                "14_AccesoDatos_EFCore",
                                "15_SesionesYCookies",
                                "16_ProgramacionAsincrona",
                                "17_LINQ",
                                "18_InyeccionDeDependencias",
                                "19_Arquitectura_SOLID",
                                "20_UnitTesting",
                                "21_Seguridad_Identity_JWT"};
            while (true) 
            {


                Console.WriteLine("Ingresa el capitulo");

                for (int i = 0; i < caps.Length; i++)
                {
                    Console.WriteLine(caps[i]);
                }


                if (int.TryParse(Console.ReadLine(), out int numCategoria))
                {
                    switch (numCategoria)
                    {
                        case 1:
                                Console.WriteLine("Seccion escogida : 01_SalidaDeDatos");
                                AprendiendoNET._01_SalidaDeDatos.MenuCapitulo.Ejecutar();
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            break;

                        case 7:
                            break;

                        case 8:
                            break;

                        case 9:
                            break;
                    }

                }
                else
                {

                }


                
            }
        }
    }
}