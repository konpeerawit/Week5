using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int value = 800000000;
        checked // check for overflow
        {
            try
            {
                int square = value * value;
            }
            catch
            {
                Console.WriteLine("{0} ^ 2 = {1},", value,value);
            }
        }
    }
}



