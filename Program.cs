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

int NumberSum(int a)
{
    int result = 0;

    while(a > 0)
    {
        result += a % 10;
        a = a/10;
    }

    return result;
    
}

int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = TakeDigit($"Input array[{i}] = ");
    }

    return array;

}

void PrintArray(int[] array)
{
    Console.WriteLine("Your array = [{0}]", string.Join(", ", array));
}

// Task 1

/*
int a = TakeDigit("Input A (digit) = ");
uint b = TakePositiveDigit("Input B (degree) = ");

System.Console.WriteLine("Result = " + AinB(a,b));
*/

// Task 2

/*
int a = TakeDigit("Input A = ");
System.Console.WriteLine("Sum = " + NumberSum(a));
*/

// Task 3

/*
int[] Array = CreateArray();
PrintArray(Array);
*/