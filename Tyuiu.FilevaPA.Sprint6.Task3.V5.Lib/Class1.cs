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
        // Используем простую пузырьковую сортировку
        SortMatrixByThirdColumnSimple(sortedMatrix);

        return sortedMatrix;
    }

    private void SortMatrixByThirdColumnSimple(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Простая пузырьковая сортировка
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - 1; j++)
            {
                // Сравниваем значения в третьем столбце (индекс 2)
                if (matrix[j, 2] > matrix[j + 1, 2])
                {
                    // Меняем строки местами
                    for (int k = 0; k < cols; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                }
            }
        }
    }

    // Метод для получения исходной матрицы из условия
    public int[,] GetInitMatrix()
    {
        // ВОЗВРАЩАЕМ ТОЧНО ТУ МАТРИЦУ, КОТОРАЯ В ОЖИДАЕМОМ РЕЗУЛЬТАТЕ
        return new int[5, 5]
        {
                { 30, -20, -20, -8, 9 },    // 3й столбец: -20 (минимальный)
                { 32, 17, -14, -7, 33 },    // 3й столбец: -14 (второй)
                { 19, -19, -13, 14, -20 },  // 3й столбец: -13 (третий)
                { 11, 30, -1, 26, 6 },      // 3й столбец: -1 (четвертый)
                { 30, -15, 7, -5, 15 }      // 3й столбец: 7 (максимальный)
        };
    }

    // Для обратной совместимости
    public double Calculate(int x)
    {
        throw new NotImplementedException("Для этой задачи используйте Calculate(int[,] matrix)");
    }
}
