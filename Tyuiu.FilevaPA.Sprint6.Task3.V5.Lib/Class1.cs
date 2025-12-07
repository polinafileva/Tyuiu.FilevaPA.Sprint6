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
        int[,] result = (int[,])matrix.Clone();

        // СОРТИРОВКА ПО 3-МУ СТОЛБЦУ (индекс 2)
        // Используем сортировку выбором
        for (int i = 0; i < rows - 1; i++)
        {
            int minIndex = i;

            // Ищем минимальное значение в 3-м столбце начиная с i
            for (int j = i + 1; j < rows; j++)
            {
                if (result[j, 2] < result[minIndex, 2])
                {
                    minIndex = j;
                }
            }

            // Если нашли меньший элемент, меняем строки местами
            if (minIndex != i)
            {
                // Меняем всю строку
                for (int k = 0; k < cols; k++)
                {
                    int temp = result[i, k];
                    result[i, k] = result[minIndex, k];
                    result[minIndex, k] = temp;
                }
            }
        }

        return result;
    }

    // Метод для получения матрицы, которую ожидает тестовая система
    public int[,] GetInitMatrix()
    {
        return new int[5, 5]
        {
                { 30, -20, 7, -8, 9 },      // 3й столбец: 7
                { 32, 17, -14, -7, 33 },    // 3й столбец: -14
                { 19, -19, -13, 14, -20 },  // 3й столбец: -13
                { 11, 30, -1, 26, 6 },      // 3й столбец: -1
                { 30, -15, -20, -5, 15 }    // 3й столбец: -20
        };
    }

    // Для обратной совместимости
    public double Calculate(int x)
    {
        throw new NotImplementedException("Для этой задачи используйте Calculate(int[,] matrix)");

    }
}