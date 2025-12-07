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

        // Сортируем строки матрицы по третьему столбцу (индекс 2) по возрастанию
        BubbleSortByThirdColumn(sortedMatrix);

        return sortedMatrix;
    }

    private void BubbleSortByThirdColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);

        // Используем пузырьковую сортировку
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                // Сравниваем значения в третьем столбце (индекс 2)
                if (matrix[j, 2] > matrix[j + 1, 2])
                {
                    // Меняем строки местами
                    SwapRows(matrix, j, j + 1);
                }
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
                { 30, -20, -20, -8, 9 },    // 3й столбец: -20 (должен быть 1-м)
                { 32, 17, -14, -7, 33 },    // 3й столбец: -14 (должен быть 2-м)
                { 19, -19, -13, 14, -20 },  // 3й столбец: -13 (должен быть 3-м)
                { 11, 30, -1, 26, 6 },      // 3й столбец: -1 (должен быть 4-м)
                { 30, -15, 7, -5, 15 }      // 3й столбец: 7 (должен быть 5-м)
        };
    }

    // Для обратной совместимости
    public double Calculate(int x)
    {
        throw new NotImplementedException("Для этой задачи используйте Calculate(int[,] matrix)");
    }
}

