enum orientation : byte
{
    north = 1,
    south =2,
    east =3,
    west = 4
}

orientation myDirection = orientation.north;

Console.WriteLine("My direction is {0}", myDirection);

Console.ReadKey();

