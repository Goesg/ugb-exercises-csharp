﻿using static fixacao_fundamentos.MenuOption;

namespace fixacao_fundamentos
{
    class Program
    {
        private static bool run = true;

        public static void Main(string[] args)
        {
            ExecuteProgram();
        }

        private static void ExecuteProgram()
        {
            while (run)
            {
                Menu.PrintMenuExercises();

                switch (Menu.GetMenuOption())
                {
                    case EXIT:
                        ExitProgram();
                        break;
                    case SOMAR_NUMEROS:
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
        }

        private static void ExitProgram()
        {
            Console.WriteLine("Exiting the program !");
            run = false;
        }
    }

    class Menu
    {
        public static void PrintMenuExercises()
        {
            Console.WriteLine("\n--- Menu Exercicios De Fixacao C-sharp [Diego Goes] ---");
            Console.WriteLine("1. Somar Numeros");
        }

        public static MenuOption GetMenuOption()
        {
            int inputOptionValue = Convert.ToInt32(Console.ReadLine());
            return (MenuOption)inputOptionValue;
        }

    }
}
