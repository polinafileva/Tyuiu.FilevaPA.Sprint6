namespace Tyuiu.FilevaPA.Sprint6.Task7.V15.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task7V15
{
    public int[,] GetMatrix(string path)
    {
        try
        {
            // Проверяем существование файла
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;

            // Определяем количество столбцов по первой строке
            string[] firstLineValues = lines[0].Split(';');
            int cols = firstLineValues.Length;

            // Создаем матрицу
            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу значениями из файла
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0; // Значение по умолчанию при ошибке парсинга
                    }
                }
            }

            // Изменяем значения в 7-м столбце (индекс 6, так как индексация с 0)
            for (int i = 0; i < rows; i++)
            {
                int value = matrix[i, 6]; // 7-й столбец

                // Проверяем условия: меньше 10 И кратно 3
                if (value < 10 && value % 3 == 0)
                {
                    matrix[i, 6] = 3; // Заменяем на 3
                }
            }

            return matrix;
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка обработки файла: {ex.Message}");
        }
    }

    // Дополнительный метод для загрузки исходной матрицы (без изменений)
    public int[,] LoadMatrix(string path)
    {
        try
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            string[] firstLineValues = lines[0].Split(';');
            int cols = firstLineValues.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка загрузки файла: {ex.Message}");
        }
    }
}
