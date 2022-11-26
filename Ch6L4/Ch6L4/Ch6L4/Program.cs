namespace Ch6L4;
class Program
{

    static int MaxValue(int[] intArray, out int maxIndex)
    {

        int maxVal = intArray[0];

        maxIndex = 0;

        for (int i = 1; i <intArray.Length; i++)
        {
            if (intArray[i] > maxVal)
            {
                maxVal = intArray[i];
                maxIndex = i;
                Console.WriteLine("the {0} it is {1}", i, intArray[i]);
            }
            
        }
        return maxVal;
   
    }
    static void Main(string[] args)
    {
        int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2,9 };

        int maxIndex;

        Console.WriteLine("The maxium value in myArray is {0}", MaxValue(myArray, out maxIndex));

        Console.WriteLine("The first occurrence of this value is at element {0}", maxIndex+1 );
        Console.WriteLine("the 7th int is {0}", myArray[6]) ;

        Console.ReadKey();
    }
}

