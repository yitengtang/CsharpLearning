// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Enter an integer: ");

int myInt = Convert.ToInt32(Console.ReadLine());

bool isLessThan10 = myInt < 10;

bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);

Console.WriteLine("Integer less than 10? {0}", isLessThan10);

Console.WriteLine("Integer is between 0 and 5? {0}", isBetween0And5);

Console.WriteLine("Ecactly one of the above is true? {0}", isBetween0And5^isLessThan10); //if one of the bool value is true then it is true

Console.ReadKey();
