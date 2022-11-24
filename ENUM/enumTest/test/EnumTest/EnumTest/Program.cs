namespace EnumTest;

enum Orientation : byte
{
    north =1,
    south = 2,
    east =3,
    west =4
}

class Program
{
    static void Main(string[] args)
    {
        

        byte directionByte;
        string directionString;

        Orientation myDirection = Orientation.north;

        directionByte = (byte)myDirection;
        directionString = Convert.ToString(myDirection);

        Console.WriteLine("My orientation is {0}", myDirection);
        Console.WriteLine("byte equivalent = {0}", directionByte);
        Console.WriteLine("string equivalent ={0}", directionString);
        Console.ReadKey();
    }
}

