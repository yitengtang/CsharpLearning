namespace SumVals;
class Program
{
    static int SumVals(params int[] vals)
    {
        int sum = 0;

        foreach (int val in vals)
        {
            sum += val;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        int sum = SumVals(1, 2, 3, 4, 5);
        Console.WriteLine("The sum vals is {0}", sum);
        Console.ReadKey();
    }
}

