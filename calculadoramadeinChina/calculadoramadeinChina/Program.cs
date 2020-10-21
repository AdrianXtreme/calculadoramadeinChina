using System;

namespace calculadoramadeinChina
{
    class Program
    {
        public static void ManageAddMenu()
        {
            while (true)
            {
                UserInterface.PrintAddMenu();

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

        }
        static void Main(string[] args)
        {
            ManageMainMenu();
        }
        
    }
}
