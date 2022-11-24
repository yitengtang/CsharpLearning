// See https://aka.ms/new-console-template for more information


string[] friendName = { "Robert Barwell", "Mike Parry", "Jeremy Beacock" };

int i;
Console.WriteLine("Here are {0} of my friends:", friendName.Length);

for (i=0; i<friendName.Length; i++)
{
    Console.WriteLine(friendName[i]);
}
Console.ReadKey();
