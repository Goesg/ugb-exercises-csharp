using ExercisesCore;

namespace ExercisesApp
{
    public class SomarNumerosApp : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Running ::: exercicio somar numeros\n");

            int x = GetInputValue();

            int y = GetInputValue();

            Console.Write($"A soma de {x} + {y} é {Sum(x, y)}");
        }

        int Sum(int x, int y)
        {
            return x + y;
        }

         public static int GetInputValue()
        {
            while (true)
            {
                Console.Write("Escolha um valor para somar: ");
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