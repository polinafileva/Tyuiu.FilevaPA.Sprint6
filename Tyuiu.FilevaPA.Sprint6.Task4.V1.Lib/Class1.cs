namespace Tyuiu.FilevaPA.Sprint6.Task4.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task4V1
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        // Проверка корректности диапазона
        if (startValue > stopValue)
        {
            throw new ArgumentException("Начальное значение не может быть больше конечного");
        }

        // Вычисление размера массива
        int length = stopValue - startValue + 1;
        double[] resultArray = new double[length];

        // Табулирование функции
        for (int i = 0; i < length; i++)
        {
            int x = startValue + i;
            resultArray[i] = CalculateFunctionValue(x);
        }

        return resultArray;
    }

    private double CalculateFunctionValue(int x)
    {
        // Функция: F(x) = sin(x) / (x + 1.2) + cos(x) * 7x - 2

        try
        {
            // Проверка деления на ноль в знаменателе дроби
            double denominator = x + 1.2;

            if (Math.Abs(denominator) < 1e-10) // Проверка на близость к нулю
            {
                return 0; // По условию при делении на ноль возвращаем 0
            }

            // Вычисление частей функции
            double fraction = Math.Sin(x) / denominator;
            double cosPart = Math.Cos(x) * 7 * x;

            // Собираем полное выражение
            double result = fraction + cosPart - 2;

            // Проверка на особые случаи
            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                return 0;
            }

            // Округление до двух знаков после запятой
            return Math.Round(result, 2);
        }
        catch (Exception)
        {
            // В случае любой ошибки возвращаем 0
            return 0;
        }
    }

    // Реализация метода из интерфейса
    public double Calculate(int x)
    {
        return CalculateFunctionValue(x);
    }
}
