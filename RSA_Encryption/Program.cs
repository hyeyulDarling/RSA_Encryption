Console.WriteLine("Enter two prime numbers: ");
int p = int.Parse(Console.ReadLine());
int q = int.Parse(Console.ReadLine());

/* Add a function to check whether p and q are primes */ 

public static bool IsPrime ( int number)
{
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