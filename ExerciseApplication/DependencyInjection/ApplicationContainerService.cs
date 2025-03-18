using System;
using Microsoft.Extensions.DependencyInjection;
using ExercisesApp;
using ExercisesCore;

namespace ExerciseApplication.DependencyInjection;

public class ApplicationContainerService
{
       public static ServiceProvider LoadContainerDependency()
        {
            return new ServiceCollection()
            .AddSingleton<IExercise, SomarNumerosApp>()
            .AddSingleton<IExerciseFactory, ExerciseUgbFactory>()
            .BuildServiceProvider();
        }

}
