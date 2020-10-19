using System;

namespace calculadoramadeinChina
{
    class Program
    {
        public static void ManageMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                    break;
                else if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opción no válida");
                }
                else if (option < 0 || option > 7)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opción no válida, introduce un número entre el 0 y el 7");
                }         
            }

        }
        static void Main(string[] args)
        {
            ManageMainMenu();
        }
        
    }
}
