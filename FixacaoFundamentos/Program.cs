using static FixacaoFundamentos.MenuOption;
using ExercisesApp;
using System;
using Microsoft.Extensions.DependencyInjection;
using ExercisesCore;

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
            var serviceProvider = BuildContainerDependency();
            IExercise exerciseApp = GetEmptyIExercise();

            while (run)
            {
                Menu.PrintMenuExercises();

                switch (Menu.GetMenuOption())
                {
                    case EXIT:
                        ExitProgram();
                        break;
                    case SOMAR_NUMEROS:
                        exerciseApp = serviceProvider.GetRequiredService<IExercise>();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                if (exerciseApp == null)
                {
                    continue;
                }

                exerciseApp.run();
            }
        }

        private static ServiceProvider BuildContainerDependency()
        {
            return new ServiceCollection()
            .AddSingleton<IExercise, SomarNumerosApp>()
            .BuildServiceProvider();
        }

        private static IExercise GetEmptyIExercise()
        {
            return null;
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
