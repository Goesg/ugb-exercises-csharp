using ExercisesCore;
using ExercisesApp;
using Microsoft.Extensions.DependencyInjection;
using static ExercisesCore.ExerciseOption;

namespace ExerciseApplication;

public class ExerciseUgbFactory : IExerciseFactory
{

    private readonly IEnumerable<IExercise> _exercises;

    public ExerciseUgbFactory(IEnumerable<IExercise> exercises)
    {
         _exercises = exercises;
    }

    public IExercise GetExercise(ExerciseOption option)
    {
        return _exercises.FirstOrDefault(exerciseImpl => exerciseImpl.GetType().Name == option.GetApplicationName()) 
               ?? throw new Exception("Exercício não encontrado.");
    }
}
