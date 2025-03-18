using System;
using Microsoft.Extensions.DependencyInjection;
using ExercisesApp;
using ExercisesCore;

namespace ExerciseApplication.DependencyInjection;

public class ApplicationContainerService
{
       public ServiceProvider BuildContainerDependency()
        {
            return new ServiceCollection()
            .AddSingleton<IExercise, SomarNumerosApp>()
            .BuildServiceProvider();
        }

}
