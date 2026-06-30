public static class StatisticsHelper
{
    public static int Sum(int[] values)
    {
        int sum = 0;
        foreach (var v in values) sum += v;
        return sum;
    }
    
    public static int Count(int[] values) => values.Length;
    
    public static double CalculateAverage(int[] values)
    {
        return (double)Sum(values) / values.Length;
    }
    
    public static int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (var v in values) if (v > max) max = v;
        return max;
    }
    
    public static int CalculateMin(int[] values)
    {
        return values[0];
    }
}