namespace Tyuiu.FilevaPA.Sprint6.Task5.V11.Lib;

using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task5V11
{
    public double[] LoadFromDataFile(string path)
    {
        try
        {
            // Проверяем существование файла
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден по пути: {path}");
            }

            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);
            List<double> result = new List<double>();

            foreach (string line in lines)
            {
                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Заменяем запятую на точку для парсинга
                string normalizedLine = line.Trim().Replace(',', '.');

                // Пробуем распарсить число
                if (double.TryParse(normalizedLine,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double number))
                {
                    // Проверяем, кратно ли число 5
                    // Для дробных чисел используем проверку с погрешностью
                    double remainder = Math.Abs(number % 5);

                    // Если остаток близок к 0 или к 5 (для отрицательных чисел)
                    if (remainder < 0.00001 || Math.Abs(remainder - 5) < 0.00001)
                    {
                        result.Add(number);
                    }
                }
            }

            return result.ToArray();
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка при обработке файла: {ex.Message}");
        }
    }
}

