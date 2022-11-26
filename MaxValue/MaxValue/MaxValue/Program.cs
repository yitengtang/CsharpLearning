namespace MaxValue;
class Program
{
    static int MaxValue(int[] intArray)
    {
        int MaxValue = intArray[0];

        for(int i = 1; i < intArray.Length; i++)
        {
            if (intArray[i] > MaxValue)
                MaxValue = intArray[i];
        }
        return MaxValue;
    }
    static void Main(string[] args)
    {
        int[] myArray = new int[5];

        Console.WriteLine("Please give me 5 number.");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("The {0} number is  ", i + 1);
            myArray[i] = Convert.ToInt32(Console.ReadLine());

        }

        int maxVal = MaxValue(myArray);

        Console.WriteLine("The max value of myArray is {0}", maxVal);

        Console.ReadKey();

    }
}

