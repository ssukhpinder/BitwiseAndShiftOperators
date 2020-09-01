using System;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Bitwise operator");         

            //Bitwise complement operator ~
            uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~a;
            Console.WriteLine(Convert.ToString(b, toBase: 2));

            Console.WriteLine("===================================");


            Console.WriteLine("===================================");
            Console.WriteLine("Left shift operator");
            //Left - shift operator <<
            uint x = 0b_1100_1001_0000_0000_0000_0000_1111_1111;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");
            uint y = x << 4;
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");


            Console.WriteLine("===================================");
            Console.WriteLine("Right shift operator");
            //Right Shift
            uint x1 = 0b_1111;
            Console.WriteLine($"Before: {Convert.ToString(x1, toBase: 2),4}");
            uint y1 = x1 >> 2;
            Console.WriteLine($"After:  {Convert.ToString(y1, toBase: 2),4}");


            Console.WriteLine("===================================");
            Console.WriteLine("Logical AND");
            //Logical And
            uint a1 = 0b_1111_1000;
            uint b1 = 0b_1001_1101;
            uint c1 = a1 & b1;
            Console.WriteLine(Convert.ToString(c1, toBase: 2));


            Console.WriteLine("===================================");
            Console.WriteLine("Logical exclusive OR");
            //Logical exclusive OR
            uint a2 = 0b_1111_1000;
            uint b2 = 0b_0001_1100;
            uint c2 = a2 ^ b2;
            Console.WriteLine(Convert.ToString(c2, toBase: 2));


            Console.WriteLine("===================================");
            Console.WriteLine("Logical OR");
            //Logical OR
            uint a3 = 0b_1010_0000;
            uint b3 = 0b_1001_0001;
            uint c3 = a3 | b3;
            Console.WriteLine(Convert.ToString(c3, toBase: 2));

            Console.WriteLine("===================================");
        }
    }
}
