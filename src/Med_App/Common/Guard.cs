namespace Med_App;
public static class Guard
{
    public static string NotEmpty(string value, string fieldName)
    {
        if (string.IsNullOrEmpty(value)) throw new ArgumentException($"{fieldName} не может быть пустым!");

        return value;
    }

    public static int Positive(int value, string fieldName)
    {
        if (value <= 0) throw new ArgumentException($"{fieldName} должен быть положительным!");

        return value;
    }
}