namespace tyuiu.denisovld.sprint1.Task6.V4.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;
public class DataService : ISprint1Task6V4
{
    public string CheckDoubleN(string value)
    {
        string res = "";
        string[] value_split;
        value_split = value.Split(new char[] { ' ', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < value_split.Length; i++)
            if (value_split[i].Contains("нн", StringComparison.CurrentCultureIgnoreCase))
            {
                res = res += (value_split[i] + " ");
                
            }
        res = res.Trim();
        return res;


    }
}

