using System;

namespace calculadoramadeinChina
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                string option = System.Console.ReadLine();
                System.Console.WriteLine("Has elegido " + option);

            }
            
        }
    }
}
