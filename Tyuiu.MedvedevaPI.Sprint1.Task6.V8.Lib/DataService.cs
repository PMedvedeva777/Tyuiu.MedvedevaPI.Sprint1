namespace Tyuiu.MedvedevaPI.Sprint1.Task6.V8.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

    public class DataService : ISprint1Task6V8
{
    public string MoveLetterToEnd(string value)
    {
        string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string result = "";
        foreach (string word in words)
        {
            if (word.Length > 1)
            {
                result += word.Substring(1) + word[0] + " ";
            }
            else
            {
                result += word + " ";
            }
        }
        return result.Trim();
    }
}
    
