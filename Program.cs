int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int result = Int32.Parse(System.Console.ReadLine());
    return result;
}

uint TakePositiveDigit(string a)
{
    System.Console.WriteLine(a);
    uint result = UInt32.Parse(System.Console.ReadLine());
    return result;
}

int AinB(int a, uint b)
{

    if(b == 0)
    {
        return 1;
    }

    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result = result * a ;
    }

    return result;
}

// Task 1

int a = TakeDigit("Input A (digit) = ");
uint b = TakePositiveDigit("Input B (degree) = ");

System.Console.WriteLine("Result = " + AinB(a,b));