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
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Обрабатываем разные форматы чисел
                string cleanLine = line.Trim().Replace(',', '.');

                if (double.TryParse(cleanLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    // Проверяем кратность 5
                    double remainder = Math.Abs(number % 5);
                    if (remainder < 0.0001 || Math.Abs(remainder - 5) < 0.0001)
                    {
                        result.Add(number);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка: {ex.Message}");
        }

        return result;
    }

    public List<double> GetAllNumbers(string path)
    {
        List<double> result = new List<double>();

        try
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string cleanLine = line.Trim().Replace(',', '.');

                if (double.TryParse(cleanLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    result.Add(number);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка: {ex.Message}");
        }

        return result;
    }
}
