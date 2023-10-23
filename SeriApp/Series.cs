class Series

{
    public int[] data = new int[16];
    public Series()
    {
        System.Console.WriteLine("Yapılandırıcı çalıştı.");
    }
    public int Min()
    {
        int minimum = data[0];
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] < minimum)
            {
                minimum = data[i];
            }
        }
        return minimum;
    }
}