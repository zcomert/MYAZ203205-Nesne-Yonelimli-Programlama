namespace StringLib;
public static class StringOperation
{
    public static int NumberOfSpaces(this String expression)
    {
        int n = 0;
        foreach (var item in expression)
        {
            if(item.Equals(' '))
            {
                n++;
            }
        }
        return n;
    }
}
