// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string comparison;

Console.WriteLine("Enter a number: ");

double var1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ener another number: ");

double var2 = Convert.ToDouble(Console.ReadLine());

if (var1 < var2)

    comparison = "less than";

else
{
    if (var1 == var2)
        comparison = "equal to";
    else
        comparison = "greater than";
}

Console.WriteLine(" ther first number is {0} the second number.", comparison );

Console.ReadKey();




