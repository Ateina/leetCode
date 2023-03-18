Console.WriteLine("isPowerOfFour");
Console.Write(isPowerOfFour(16));

bool isPowerOfFour(int n)
{
    if (n == 0) { return false; }
    if (n == 1) { return true; }
    else
    {
        double d = (double)n / 4;
        bool isInt = (int)d == d;
        if (isInt)
        {
            return isPowerOfFour((int)d);
        }
        else
        {
            return false;
        }
    }
}