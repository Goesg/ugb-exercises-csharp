using System;
using ExercisesCore;

namespace ExerciseApplication;

public interface IExerciseFactory
{
    public IExercise GetExercise(ExerciseOption option);
}
