using System;
using Microsoft.Extensions.DependencyInjection;
using ExerciseApplication.DependencyInjection;
using ExercisesCore;

namespace ExerciseApplication;

public class RunnerExercise
{
    ServiceProvider? contextApplication;

    public void Execute(ExerciseOption exercise)
    {
        try
        {
            IExercise exerciseApp = GetExerciseFactory().GetExercise(exercise);
            exerciseApp.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro execute Exercise :" + ex.Message);
        }

    }

    ServiceProvider GetContainerApplication()
    {
        if (contextApplication != null) return contextApplication;

        contextApplication = ApplicationContainerService.LoadContainerDependency();
        return contextApplication;
    }

    IExerciseFactory GetExerciseFactory()
    {
        return GetContainerApplication().GetRequiredService<IExerciseFactory>();
    }
}
