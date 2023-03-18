Console.WriteLine("isPowerOfTwo");
Console.Write(isPowerOfTwo(4));

bool isPowerOfTwo(int n)
{
    if (n == 0) { return false; }
    if (n == 1) { return true; }
    else
    {
        double d = (double)n / 2;
        bool isInt = (int)d == d;
        if (isInt)
        {
            return isPowerOfTwo((int)d);
        }
        else
        {
            return false;
        }
    }
}