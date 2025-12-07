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

        // Создаем копию матрицы
        int[,] sortedMatrix = (int[,])matrix.Clone();

        // Используем сортировку вставками для стабильности
        InsertionSortByThirdColumn(sortedMatrix);

        return sortedMatrix;
    }

    private void InsertionSortByThirdColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 1; i < rows; i++)
        {
            // Сохраняем текущую строку
            int[] currentRow = new int[cols];
            for (int c = 0; c < cols; c++)
            {
                currentRow[c] = matrix[i, c];
            }

            int currentValue = currentRow[2]; // значение в третьем столбце
            int j = i - 1;

            // Сдвигаем строки, у которых значение в 3м столбце больше текущего
            while (j >= 0 && matrix[j, 2] > currentValue)
            {
                // Копируем строку j в строку j+1
                for (int c = 0; c < cols; c++)
                {
                    matrix[j + 1, c] = matrix[j, c];
                }
                j--;
            }

            // Вставляем сохраненную строку на правильное место
            for (int c = 0; c < cols; c++)
            {
                matrix[j + 1, c] = currentRow[c];
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
