namespace Tyuiu.FilevaPA.Sprint6.Task6.V19.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task6V19
{
    public string CollectTextFromFile(string path)
    {
        try
        {
            // Проверяем существование файла
            if (!File.Exists(path))
            {
                return "File not found: " + path;
            }

            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);
            List<string> resultWords = new List<string>();

            foreach (string line in lines)
            {
                // Разделяем строку на слова (пробел, табуляция)
                string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    string cleanWord = word.Trim();

                    // Проверяем, содержит ли слово букву 'l' или 'L'
                    if (cleanWord.Contains("l") || cleanWord.Contains("L"))
                    {
                        resultWords.Add(cleanWord);
                    }
                }
            }

            // Объединяем слова в одну строку через пробел
            return string.Join(" ", resultWords);
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }

    // Альтернативный метод с использованием StreamReader
    public string LoadDataFromFile(string path)
    {
        try
        {
            if (!File.Exists(path))
                return "File does not exist";

            List<string> wordsWithL = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.IndexOf('l') >= 0 || word.IndexOf('L') >= 0)
                        {
                            wordsWithL.Add(word);
                        }
                    }
                }
            }

            return string.Join(" ", wordsWithL);
        }
        catch (Exception ex)
        {
            return "Error reading file: " + ex.Message;
        }
    }
}
