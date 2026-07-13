using System.Numerics;
Random random = new Random();

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
int p = Convert.ToInt32(Console.ReadLine());
int q = Convert.ToInt32(Console.ReadLine()); 

/* This while loop continues asking the user for a correct input until it is recieved */
while(IsPrime(p) == false || IsPrime(q) == false)
{
    if(IsPrime(p) == false)
    {
        Console.WriteLine("Enter a prime number p: ");
        p = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Enter a prime number q: ");
        q = Convert.ToInt32(Console.ReadLine());
    }
}

/* n is the modulus used in calculations */
int n = p * q;

/* Phi_n stores the number of integers that are less than n and coprime to n --> this means no primes other than one are shared */
int Phi_n = (p-1)*(q-1);

/* Calculates exponent e */

int e; /* No value assigned to e yet */

do
{
    e = random.Next(2, Phi_n);
}
while(!IsCoPrime(e, Phi_n));


/* Checks whether e is coprime with Phi_n */
static bool IsCoPrime(int e, int Phi_n)
{
    BigInteger gcd = BigInteger.GreatestCommonDivisor(e, Phi_n);

    return gcd == 1; /*returns true or false based on this statement alone */
}
Console.WriteLine(e);