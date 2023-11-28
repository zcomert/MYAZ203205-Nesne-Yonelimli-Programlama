namespace Circle;
public static class Circle
{
    static Circle()
    {
        
    }
    public static double CalculateCircumference(double r) => 2* Math.PI * r;
    public static double CalculateArea(double r) 
    {
        var result = Math.PI * Math.Pow(r, 2);
        return result;
    }
}
