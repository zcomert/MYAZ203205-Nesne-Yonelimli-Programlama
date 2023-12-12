namespace IntLib;
public static class IntOpetation
{
    public static String UntilNumber(this int number)
    {
        String s = String.Empty;
        for (int index = 0; index < number; index++)
        {
            s += (index+1) + " ";
        }
        return s;
    }
}
