Console.WriteLine("isPowerOfThree");
Console.Write(isPowerOfThree(9));

bool isPowerOfThree(int n)
{
    if (n == 0) { return false; }
    if (n == 1) { return true; }
    else
    {
        double d = (double)n / 3;
        bool isInt = (int)d == d;
        if (isInt)
        {
            return isPowerOfThree((int)d);
        }
        else
        {
            return false;
        }
    }
}