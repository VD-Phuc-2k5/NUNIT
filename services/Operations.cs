namespace services;

public class MinMaxResult
{
    private readonly int minNumber;    
    private readonly int maxNumber;
    
    public int MinNumber
    {
        get { return minNumber; }
    }

    public int MaxNumber
    {
        get { return maxNumber; }
    }

    public MinMaxResult(int minValue, int maxValue)
    {
        this.minNumber = minValue;
        this.maxNumber = maxValue;
    }
}

public class Operations 
{
    public static int Add(int a, int b) {
        return a + b;
    }
    
    public static MinMaxResult MaxMin(int a, int b, int c)
    {
       if ( a == b && b == c) {
        return new MinMaxResult(-1, -1);
       }
       int maxNumber = Math.Max(a, Math.Max(b, c));
       int minNumber = Math.Min(a, Math.Min(b, c));
         return new MinMaxResult(minNumber, maxNumber);
    }
}
