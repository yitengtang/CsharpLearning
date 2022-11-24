// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double balance, interestRate, targetBalance;

Console.WriteLine("What is your current balance? ");

balance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is your current annual interest rat (in %)?");

interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;

Console.WriteLine("What balance you would to have?");

targetBalance = Convert.ToDouble(Console.ReadLine());

int totalYears = 0;

do
{
    balance *= interestRate;
    ++totalYears;
}
while (balance < targetBalance);

Console.WriteLine("In {0} years {1} you will have a balance of {2}", totalYears,totalYears==1?"":"s", balance);

Console.ReadKey();



