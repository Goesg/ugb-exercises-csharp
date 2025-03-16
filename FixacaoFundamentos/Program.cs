using static FixacaoFundamentos.MenuOption;
using System;
using System.Diagnostics;

namespace FixacaoFundamentos
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
                        Process.Start("dotnet", "run --project ../ExecSomarNumerosApp/ExecSomarNumerosApp.csproj");
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
