using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoramadeinChina
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.White;
            System.Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            System.Console.WriteLine("       Calculadora Made in China       ");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("1) Sumar una serie de números");
            System.Console.WriteLine("2) Restar una serie de números");
            System.Console.WriteLine("3) Multiplicar una serie de números");
            System.Console.WriteLine("4) Dividir una serie de números");
            System.Console.WriteLine("5) Calcular raíz cuadrada de un número");
            System.Console.WriteLine("6) Comprobar si un número es primo");
            System.Console.WriteLine("7) Calcular sumatorio de un número");
            System.Console.WriteLine("0) Salir de la aplicación");
        }

        public static void PrintAddHeader()
        {
            System.Console.WriteLine("            Suma de números            ");
            System.Console.WriteLine("---------------------------------------");
        }

        public static void PrintAddSubmenu()
        {
            System.Console.WriteLine("1) Sumar otro número");
            System.Console.WriteLine("2) Realizar otra suma");
            System.Console.WriteLine("0) Salir al menú principal");

        }
.
        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
            try
            {
                int result = System.Convert.ToInt32(option);
                return result;
            }

            catch (System.Exception e)
            {
                return -1;
            }

        }
        
        public static int ReadMenuOption(int MinMenuOption, int MaxMenuOption)
        {
            while (true)
            {
                int option = ReadMenuOption();
                if (option >= MinMenuOption && option <= MaxMenuOption)
                    return option;
                else
                    System.Console.WriteLine("Opción fuera de rango: ");
            }
        }

    }
}
