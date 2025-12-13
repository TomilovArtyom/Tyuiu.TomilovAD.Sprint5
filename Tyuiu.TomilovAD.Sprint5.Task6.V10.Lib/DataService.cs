using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;


namespace Tyuiu.TomilovAD.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] separators = {',', '.'};
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Length > 4)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
