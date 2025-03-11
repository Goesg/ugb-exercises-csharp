﻿using Aula2_1bim;

namespace fixacao_fundamentos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean run = true;

            while(run)
            {
                Menu.printMenuExercises();
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting the program !");
                        run = false;
                        break;
                     case 1:
                        Aula2_1bim.SomarNumerosApp.run();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
               
            }
        }
    }

    class Menu
    {
        public static void printMenuExercises()
        {
            Console.WriteLine("\n--- Exercicios De Fixacao Menu ---");
            Console.WriteLine("1. Somar Numeros");
        }
    }
}
