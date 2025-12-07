namespace Tyuiu.FilevaPA.Sprint6.Task5.V11.Lib;

using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task5V11
{
    public double[] LoadFromDataFile(string path)
    {
        List<double> result = new List<double>();

        try
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                // Пробуем преобразовать строку в число
                if (double.TryParse(line.Trim().Replace(',', '.'),
                                   System.Globalization.NumberStyles.Any,
                                   System.Globalization.CultureInfo.InvariantCulture,
                                   out double number))
                {
                    // Проверяем, кратно ли число 5
                    if (IsMultipleOfFive(number))
                    {
                        result.Add(number);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Генерируем исключение с информацией об ошибке
            throw new Exception("Ошибка чтения файла: " + ex.Message);
        }

        return result;
    }

    // Вспомогательный метод для проверки кратности 5
    private bool IsMultipleOfFive(double number)
    {
        // Для вещественных чисел проверяем с небольшой погрешностью
        double remainder = Math.Abs(number % 5);
        return remainder < 0.0001 || Math.Abs(remainder - 5) < 0.0001;
    }

    // Метод для получения всех чисел (не только кратных 5)
    public List<double> GetAllNumbers(string path)
    {
        List<double> result = new List<double>();

        try
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                if (double.TryParse(line.Trim().Replace(',', '.'),
                                   System.Globalization.NumberStyles.Any,
                                   System.Globalization.CultureInfo.InvariantCulture,
                                   out double number))
                {
                    result.Add(number);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Ошибка чтения файла: " + ex.Message);
        }

        return result;
    }
}

