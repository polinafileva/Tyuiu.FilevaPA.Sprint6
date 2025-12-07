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
        SortMatrixByThirdColumn(sortedMatrix);

        return sortedMatrix;
    }

    private void SortMatrixByThirdColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);

        // Используем сортировку вставками для стабильности
        for (int i = 1; i < rows; i++)
        {
            int[] currentRow = new int[5];
            int currentValue = matrix[i, 2];

            // Сохраняем текущую строку
            for (int col = 0; col < 5; col++)
            {
                currentRow[col] = matrix[i, col];
            }

            int j = i - 1;

            // Сдвигаем элементы, которые больше currentValue
            while (j >= 0 && matrix[j, 2] > currentValue)
            {
                for (int col = 0; col < 5; col++)
                {
                    matrix[j + 1, col] = matrix[j, col];
                }
                j--;
            }

            // Вставляем текущую строку на правильное место
            for (int col = 0; col < 5; col++)
            {
                matrix[j + 1, col] = currentRow[col];
            }
        }
    }

    // Метод для получения исходной матрицы из условия
    public int[,] GetInitMatrix()
    {
        return new int[5, 5]
        {
                { 30, -20, -20, -8, 9 },    // 3й столбец: -20
                { 32, 17, -14, -7, 33 },    // 3й столбец: -14
                { 19, -19, -13, 14, -20 },  // 3й столбец: -13
                { 11, 30, -1, 26, 6 },      // 3й столбец: -1
                { 30, -15, 7, -5, 15 }      // 3й столбец: 7
        };
    }

    // Для обратной совместимости
    public double Calculate(int x)
    {
        throw new NotImplementedException("Для этой задачи используйте Calculate(int[,] matrix)");
    }
}

