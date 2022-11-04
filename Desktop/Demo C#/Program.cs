class Program
{
    static void Main(string[] args)
    {
        array();
    }
    public static void sum()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n+1; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }
    public static void array()
    {
        //int[] array = new int[] {2,3,4};
        int[] array = new int[10];
        int n = Convert.ToInt32(Console.ReadLine());
        int max = 0;
        for (int i = 0; i < n;i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int k = 0; k < n; k++)
        {
            if (array[k] > max)
            {
                max = array[k];
            }
        }
        Console.WriteLine(max);

    }
}