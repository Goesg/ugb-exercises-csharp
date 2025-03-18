using System;
using ExercisesCore;
using ExerciseApplication;

namespace FixacaoFundamentos
{
    class Program
    {
        private static bool run = true;
        private const int EXIT_PROGRAM_OPTION = 0;
        private static RunnerExercise Runner = new RunnerExercise();

        public static void Main(string[] args)
        {
            ExecuteProgram();
        }

        private static void ExecuteProgram()
        {
            while (run)
            {
                Menu.PrintMenuExercises();
                int menuOption = Menu.GetInputOption();

                if (!EXIT_PROGRAM_OPTION.Equals(menuOption)) ExecuteExercise(menuOption);
                else ExitProgram();
            }
        }

        private static void ExecuteExercise(int menuOption)
        {
            try
            {
                Runner.Execute(ExerciseOptionHelper.GetByValue(menuOption));
            }
            catch (Exception)
            {
                Console.WriteLine("Nenhum exercício encontrado para esta opção. Por favor, escolha um número válido exibido no menu.");
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

        public static int GetInputOption()
        {
            while (true)
            {
                Console.Write("Escolha uma opção do menu: ");
                string? inputOption = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputOption))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    continue;
                }

                try
                {
                    return Convert.ToInt32(inputOption);
                }
                catch (FormatException)
                {
                    Console.WriteLine("[FormatException] Entrada inválida. Por favor, digite um número.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("[OverflowException] Entrada inválida. Insira um número válido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }

    }
}
