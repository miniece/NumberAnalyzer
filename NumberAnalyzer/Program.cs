using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

bool valid = true;


Console.WriteLine("Please enter in your name.");
string name = Console.ReadLine();
while (valid)
{

Console.WriteLine("Please enter a number between 1 and 100");
double num = double.Parse(Console.ReadLine());
    
    while (num < 0) 
    {
        Console.WriteLine(name + ", that number is clearly below one. Please try again.");
        num = double.Parse(Console.ReadLine());
    }

    while (num > 100)
    {
        Console.WriteLine(name + ", please try a number that is UNDER 100.");
        num = double.Parse(Console.ReadLine());
    }


if (num < 60 && num % 2 != 0)
{
    Console.WriteLine(name + ", " + num + " is odd and less than 60.");
}
else if (num >=2 && num <=24 && num % 2 ==0)
{
    Console.WriteLine(name + ", " + num + " is even and less than 25.");
}
else if (num >=26 && num <=60)
{
    Console.WriteLine(name + ", " + num + " is even and between 26 and 60.");
}
else if (num > 60 && num % 2 == 0)
{
    Console.WriteLine(name + ", " + num + " is even and greater than 60.");
}

else
{
    Console.WriteLine(name + ", " + num + " is odd and greater than 60.");
}
    Console.WriteLine("Would you like to go again? Enter y or n");
    string goAgain = Console.ReadLine();

    if (goAgain == "y")
    {
        valid = true;
    }
    else if (goAgain == "n")
    {
        valid = false;
    }

}