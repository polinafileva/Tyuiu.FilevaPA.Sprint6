namespace Tyuiu.FilevaPA.Sprint6.Task5.V11.Lib;

using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task5V11
{
    public double[] LoadFromDataFile(string path)
    {
        List<double> allNumbers = new List<double>();
        List<double> multiplesOfFive = new List<double>();

        try
        {
            // Чтение всех строк из файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Заменяем запятую на точку для корректного парсинга
                string normalizedLine = line.Replace(',', '.');

                // Пробуем распарсить число
                if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    allNumbers.Add(number);

                    // Проверяем, кратно ли число 5 (с учетом погрешности для double)
                    if (Math.Abs(number % 5) < 0.0001 || Math.Abs(number % 5 - 5) < 0.0001)
                    {
                        multiplesOfFive.Add(number);
                    }
                }
                else
                {
                    // Если не удалось распарсить, попробуем другой формат
                    normalizedLine = normalizedLine.Trim();
                    if (!string.IsNullOrEmpty(normalizedLine))
                    {
                        // Попробуем найти числа в строке
                        string[] tokens = normalizedLine.Split(new char[] { ' ', '\t', ';' },
                                                             StringSplitOptions.RemoveEmptyEntries);
                        foreach (string token in tokens)
                        {
                            string normalizedToken = token.Replace(',', '.');
                            if (double.TryParse(normalizedToken, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                            {
                                allNumbers.Add(num);

                                if (Math.Abs(num % 5) < 0.0001 || Math.Abs(num % 5 - 5) < 0.0001)
                                {
                                    multiplesOfFive.Add(num);
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка при чтении файла: {ex.Message}");
        }

        return multiplesOfFive;
    }

    // Метод для получения всех чисел из файла
    public List<double> GetAllNumbers(string path)
    {
        List<double> allNumbers = new List<double>();

        try
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string normalizedLine = line.Replace(',', '.');

                if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    allNumbers.Add(number);
                }
                else
                {
                    normalizedLine = normalizedLine.Trim();
                    if (!string.IsNullOrEmpty(normalizedLine))
                    {
                        string[] tokens = normalizedLine.Split(new char[] { ' ', '\t', ';' },
                                                             StringSplitOptions.RemoveEmptyEntries);
                        foreach (string token in tokens)
                        {
                            string normalizedToken = token.Replace(',', '.');
                            if (double.TryParse(normalizedToken, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                            {
                                allNumbers.Add(num);
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка при чтении файла: {ex.Message}");
        }

        return allNumbers;
    }

    // Метод для проверки кратности 5 (с учетом погрешности)
    public bool IsMultipleOfFive(double number)
    {
        double remainder = Math.Abs(number % 5);
        return remainder < 0.0001 || Math.Abs(remainder - 5) < 0.0001;
    }
}

