namespace Tyuiu.FilevaPA.Sprint6.Task3.V5.Lib;
     using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task3V5
{
    public int[,] Calculate(int[,] matrix)
    {
        if (matrix == null)
            throw new ArgumentNullException(nameof(matrix));

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 5 || cols != 5)
            throw new ArgumentException("Матрица должна быть 5x5");

        // Создаем копию матрицы
        int[,] result = (int[,])matrix.Clone();

        // Собираем значения 3-го столбца
        int[] columnValues = new int[5];
        for (int i = 0; i < 5; i++)
        {
            columnValues[i] = result[i, 2];
        }

        // Сортируем значения
        Array.Sort(columnValues);

        // Заменяем значения в 3-м столбце на отсортированные
        // НО НЕ ПЕРЕМЕЩАЕМ СТРОКИ!
        for (int i = 0; i < 5; i++)
        {
            result[i, 2] = columnValues[i];
        }

        return result;
    }

    // Для обратной совместимости
    public double Calculate(int x)
    {
        throw new NotImplementedException("Для этой задачи используйте Calculate(int[,] matrix)");
    }
}