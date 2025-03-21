namespace ExercisesCore;

public enum ExerciseOption
{
    SOMAR_NUMEROS_APP = 1
}

public static class ExerciseOptionHelper
{
    public static ExerciseOption GetByValue(int value)
    {
        return value switch
        {
            1 => ExerciseOption.SOMAR_NUMEROS_APP,
            _ => throw new Exception("Exercise not found")
        };
    }

    public static string GetApplicationName(this ExerciseOption option)
    {
        return option switch
        {
            ExerciseOption.SOMAR_NUMEROS_APP => "SomarNumerosApp",
            _ => "InvalidApp"
        };
    }
}