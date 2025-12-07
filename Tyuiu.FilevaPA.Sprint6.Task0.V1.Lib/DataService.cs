namespace Tyuiu.FilevaPA.Sprint6.Task0.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;
public class DataService : ISprint6Task0V1
{
    public double Calculate(int x)
    {
        // s(x) = x / (x³ + 2)
        double denominator = Math.Pow(x, 3) + 2;

        // Проверка деления на ноль
        if (Math.Abs(denominator) < double.Epsilon)
        {
            return 0;
        }

        double result = x / denominator;

        // Проверка на особые случаи
        if (double.IsNaN(result) || double.IsInfinity(result))
        {
            return 0;
        }

        return Math.Round(result, 3);
    }
}
