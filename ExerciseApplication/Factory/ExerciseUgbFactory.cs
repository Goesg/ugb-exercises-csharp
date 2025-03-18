using ExercisesCore;
using ExercisesApp;
using Microsoft.Extensions.DependencyInjection;
using static ExercisesCore.ExerciseOption;

namespace ExerciseApplication;

public class ExerciseUgbFactory : IExerciseFactory
{

    private readonly IServiceProvider _serviceProvider;

    public ExerciseUgbFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IExercise GetExercise(ExerciseOption option)
    {
        return option switch
        {
            SOMAR_NUMEROS_APP => _serviceProvider.GetRequiredService<SomarNumerosApp>(),
            _ => throw new Exception("Exercício não encontrado.")
        };
    }
}
