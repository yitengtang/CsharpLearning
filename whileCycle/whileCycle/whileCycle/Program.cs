// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double balance, interestRate, targetBalance;

Console.WriteLine("What is your current balance?");

balance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is current annual interest rate (in %)?");

interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;

Console.WriteLine("What is the goal of the balance?");

targetBalance = Convert.ToDouble(Console.ReadLine());

int totalYear = 0;

while (balance < targetBalance)
{
    balance *= interestRate;
    ++totalYear;
}

Console.WriteLine("You need {0} year{1} to achieve your target balance at {2}.", totalYear, totalYear ==1? "":"s", balance);

Console.ReadKey();




