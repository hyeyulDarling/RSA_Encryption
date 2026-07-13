static bool IsPrime ( int number)
{
    /* Function to check whether a number is prime */
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i ++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Enter two prime numbers: ");
int p = Convert.ToInt16(Console.ReadLine());
int q = Convert.ToInt16(Console.ReadLine()); 

/* This while loop continues asking the user for a correct input until it is recieved */
while(IsPrime(p) == false || IsPrime(q) == false)
{
    if(IsPrime(p) == false)
    {
        Console.WriteLine("Enter a prime number p: ");
        p = Convert.ToInt16(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Enter a prime number q: ");
        q = Convert.ToInt16(Console.ReadLine());
    }
}
