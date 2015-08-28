using System;
using System.Linq;
using System.Text;
public static class Extension
{
    public static StringBuilder Substring(this StringBuilder sb, int index, int length)
    {
        StringBuilder result = new StringBuilder();
        string temp = sb.ToString();
        temp = temp.Substring(index, length);
        result.Append(temp);
        return result;
    }
}