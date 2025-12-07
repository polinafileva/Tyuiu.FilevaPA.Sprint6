namespace Tyuiu.FilevaPA.Sprint6.Task3.V5.Lib;
     using tyuiu.cources.programming.interfaces.Sprint6;

    public class Class1 : ISprint6Task3V5
{
    public int[,] Calculate(int[,] matrix)
    {
        // Проверка входных данных
        if (matrix == null)
        {
            throw new ArgumentNullException(nameof(matrix), "Матрица не может быть null");
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Проверка размерности (5x5 по условию)
        if (rows != 5 || cols != 5)
        {
            throw new ArgumentException("Матрица должна быть размером 5x5");
        }

        // Создаем копию матрицы, чтобы не изменять оригинал
        int[,] sortedMatrix = (int[,])matrix.Clone();

        // Сортируем строки матрицы по третьему столбцу (индекс 2)
        SortMatrixByThirdColumn(sortedMatrix);

        return sortedMatrix;
    }

    private void SortMatrixByThirdColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Используем сортировку выбором (selection sort) для строк матрицы
        for (int i = 0; i < rows - 1; i++)
        {
            // Находим минимальный элемент в третьем столбце начиная с позиции i
            int minIndex = i;
            for (int j = i + 1; j < rows; j++)
            {
                if (matrix[j, 2] < matrix[minIndex, 2])
                {
                    minIndex = j;
                }
            }

            // Если нашли элемент меньше текущего, меняем строки местами
            if (minIndex != i)
            {
                SwapRows(matrix, i, minIndex);
            }
        }
    }

    private void SwapRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);

        for (int col = 0; col < cols; col++)
        {
            int temp = matrix[row1, col];
            matrix[row1, col] = matrix[row2, col];
            matrix[row2, col] = temp;
        }
    }

    // Метод для получения исходной матрицы из условия
    public int[,] GetInitMatrix()
    {
        return new int[5, 5]
        {
                { 30, -20, 7, 8, 9 },
                { 32, 17, -14, 7, 33 },
                { 19, -19, -13, 14, -20 },
                { 11, 30, -1, 26, 6 },
                { 30, -15, -20, 5, 15 }
        };
    }

    // Дополнительный метод для обратной совместимости, если нужен
    public double Calculate(int x)
    {
        throw new NotImplementedException("Для этой задачи используйте Calculate(int[,] matrix)");
    }
}


