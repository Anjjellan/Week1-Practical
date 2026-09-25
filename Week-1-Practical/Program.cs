void Task1()
{
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello {name}, you will be {age + 5} in 5 years.");
}

void Task2()
{
    Console.WriteLine("Enter Your Age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 0 || age > 110)
    {
        Console.WriteLine("Invalid age entered. Please enter a valid age between 0 and 110.");

    }
    else if (age < 13)
    {
        Console.WriteLine("You are a child.");

    }
    else if (age <= 19)
    {
        Console.WriteLine("You are a teenager.");
    }
    else
    {
        Console.WriteLine("You are an adult.");
    }
}

void Task3()
{
    Console.WriteLine("Please enter an integer number:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0)
    {
        Console.WriteLine("The number is negative.");
    }
    else if (number == 0)
    {
        Console.WriteLine("The number is zero.");
    }
    else
    {
        Console.WriteLine("The number is positive.");
    }

}

void Task4()
{
    Console.WriteLine("Please enter a year:");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year < 0)
    {
        Console.WriteLine("Invalid year entered. Please enter a valid year.");
    }
    else if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
}

void Task5()
{
    Console.WriteLine("Please enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine($"The number {number} is even.");
    }
    else
    {
        Console.WriteLine($"The number {number} is odd.");
    }
}
