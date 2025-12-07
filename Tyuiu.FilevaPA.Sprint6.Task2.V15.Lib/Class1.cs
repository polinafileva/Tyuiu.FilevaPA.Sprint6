namespace Tyuiu.FilevaPA.Sprint6.Task2.V15.Lib;
    using tyuiu.cources.programming.interfaces.Sprint6;

    public class Class1 : ISprint6Task2V15
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
        // Функция: F(x) = (2 * sin(x)) / (3x + 1.2) + cos(x) - 7x * 2

        // Проверка деления на ноль в знаменателе дроби
        double denominator = 3 * x + 1.2;

        // Проверка деления на ноль (с учетом погрешности для double)
        if (Math.Abs(denominator) < 1e-10)
        {
            // По условию при делении на ноль возвращаем 0
            return 0;
        }

        try
        {
            // Вычисление частей функции
            double fraction = (2 * Math.Sin(x)) / denominator;
            double cosPart = Math.Cos(x);
            double linearPart = 7 * x * 2; // 7x * 2 = 14x

            // Собираем полное выражение
            double result = fraction + cosPart - linearPart;

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

    // Реализация метода из интерфейса (для обратной совместимости)
    public double Calculate(int x)
    {
        return CalculateFunctionValue(x);
    }
}

