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

        // Проверка размерности
        if (rows != 5 || cols != 5)
        {
            throw new ArgumentException("Матрица должна быть размером 5x5");
        }

        // Создаем список для сортировки
        var rowList = new List<int[]>();

        // Заполняем список строками матрицы
        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = matrix[i, j];
            }
            rowList.Add(row);
        }

        // СОРТИРУЕМ ТОЛЬКО ПО ТРЕТЬЕМУ СТОЛБЦУ (индекс 2)
        rowList.Sort((a, b) => a[2].CompareTo(b[2]));

        // Преобразуем обратно в матрицу
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = rowList[i][j];
            }
        }

        return result;
    }

    // Метод для получения ИСХОДНОЙ матрицы из вашего скриншота
    public int[,] GetInitMatrix()
    {
        return new int[5, 5]
        {
                { 30, -20, 7, -8, 9 },      // 3й столбец: 7
                { 32, 17, -14, -7, 33 },    // 3й столбец: -14
                { 19, -19, 13, 14, -20 },   // 3й столбец: 13
                { 11, 30, -1, 26, 6 },      // 3й столбец: -1
                { 30, -15, 20, -5, 15 }     // 3й столбец: 20
        };
    }

    // Метод для получения матрицы из ошибки тестовой системы
    public int[,] GetTestMatrix()
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
