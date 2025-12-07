namespace Tyuiu.FilevaPA.Sprint6.Task1.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task1V7
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
        // Функция: F(x) = (2x - 3) / (cos(x) + x) + 5

        // Вычисление знаменателя
        double denominator = Math.Cos(x) + x;

        // Проверка деления на ноль
        if (Math.Abs(denominator) < 1e-10)
        {
            // По условию при делении на ноль возвращаем 0
            return 0;
        }

        // Вычисление значения функции
        double numerator = 2 * x - 3;
        double fraction = numerator / denominator;
        double result = fraction + 5;

        // Проверка на особые случаи
        if (double.IsNaN(result) || double.IsInfinity(result))
        {
            return 0;
        }

        // Округление до двух знаков после запятой
        return Math.Round(result, 2);
    }

    // Реализация метода из интерфейса (для обратной совместимости)
    public double Calculate(int x)
    {
        return CalculateFunctionValue(x);
    }
}
    
