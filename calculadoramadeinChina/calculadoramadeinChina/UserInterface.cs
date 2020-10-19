using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoramadeinChina
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
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

        public static int ReadOption()
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

            //finally
            //{
            //
            //}

            // int result = System.Int32.Parse(option);
            // int op1 = int.Parse(option);
            //int result = System.Convert.ToInt32(option);
            //return result;

        }
    }
}
