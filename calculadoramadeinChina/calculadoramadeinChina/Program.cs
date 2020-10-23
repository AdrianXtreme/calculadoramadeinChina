﻿using System;

namespace calculadoramadeinChina
{
    class Program
    {
        public static void ManageAddSubmenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled = Accumuled + number;
                //Accumuled += number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintAddSubmenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }
            }
        }
        public static void ManageAddMenu()
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduce el primer número: ");
                int number2 = ManageUtils.ReadInteger("Introduce el segundo número: ");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es " + result);
                UserInterface.PrintAddSubmenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                {
                    return;
                }

                else if (option == 2)
                {
                    System.Console.Clear();
                }

                else if (option == 1)
                {
                    ManageAddSubmenu(result);
                }
            }
        }
        public static void ManageMainMenu()
        {
            bool finished = false;
            while (finished == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case -1:
                        System.Console.Clear();
                        System.Console.WriteLine("Opción no válida");
                        break;
                    case 1:
                        ManageAddMenu();          
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 0:
                        finished = true;
                        break;

                }


                if (option == 0)
                    break;               
            }
            System.Console.WriteLine("Fin del menú principal");

        }
        static void Main(string[] args)
        {
            ManageMainMenu();
        }
        
    }
}
