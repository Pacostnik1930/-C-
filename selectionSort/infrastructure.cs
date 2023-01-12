public static class Infrastructure
{
    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
               .Select( item => Random.Shared.Next(1,10))
               .ToArray();
    }

    public static void PrintArray( int[] array)
    {
        Console.WriteLine($"[{string.Join(',',array)}]");
    }
}