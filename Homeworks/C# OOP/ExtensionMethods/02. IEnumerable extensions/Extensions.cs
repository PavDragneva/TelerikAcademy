using System;
using System.Collections.Generic;
using System.Linq;
public static class Extensions
{
    public static T Sum<T>(this IEnumerable<T> some)
    {
        T sum = default(T);
        foreach(T unit in some)
        {
            sum += (dynamic)unit;
        }
        return sum;
    }
    public static T Product<T>(this IEnumerable<T> some)
    {
        checked
        {
            T product = (dynamic)1;
            foreach(T unit in some)
            {
                product *= (dynamic)unit;
            }
            return product;
        }
    }
    public static T Min<T>(this IEnumerable<T> some)
    {
        T min = some.First();
        foreach(T unit in some)
        {
            if(unit < (dynamic)min)
            {
                min = unit;
            }
        }
        return min;
    }
    public static T Max<T>(this IEnumerable<T> some)
    {
        T max = some.First();
        foreach(T unit in some)
        {
            if(unit > (dynamic)max)
            {
                max = unit;
            }
        }
        return max;
    }
    public static T Average<T>(this IEnumerable<T> some)
    {
        T sum = some.Sum();
        T avg = (dynamic)sum / some.Count();
        return avg;
    }
}