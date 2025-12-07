namespace Tyuiu.FilevaPA.Sprint6.Task6.V19.Lib;

using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

public class Class1 : ISprint6Task6V19
{
    public string CollectTextFromFile(string path)
    {
        try
        {
            StringBuilder result = new StringBuilder();

            // Читаем файл
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    // Ищем буквы: l, L, I (английская i заглавная)
                    if (word.IndexOf('l') >= 0 || word.IndexOf('I') >= 0)
                    {
                        if (result.Length > 0)
                            result.Append(" ");
                        result.Append(word);
                    }
                }
            }

            return result.ToString();
        }
        catch
        {
            return "";
        }
    }
}
