using System;

namespace SimpleProgramm
{

    class Comma {
        static void Main()
        {
            int i, j;
            int smallest, largest;
            int num;

            num = 100;

            smallest = largest = 1;

            for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
            {
                if ((smallest == 1) &((num % i) == 0))
                smallest = i;
            if ((largest == 1) & ((num % j) == 0))
                largest = j;
        }
            Console.WriteLine("largest multiplier: " + largest);
            Console.WriteLine("smallest multiplier: " + smallest);
        }
 }
   // class FindPrimes {
   //     static void Main()
   //     { 
   //     int num;
   //     int i;
   //     int factor;
   //     bool isprime;

   //     for (num = 2; num<20; num++)
			//{
   //         isprime = true;
   //         factor = 0;
			
   //         for (i = 2; i <= num/2; i++)
   //         {
   //             if ((num % i) == 0) {
   //                 isprime = false;
   //                 factor = i;
   //             }

   //         }
   //         if (isprime)
   //             Console.WriteLine(num + " - simple digit.");
   //         else
   //             Console.WriteLine("biggest * digit" + num + "equals" + factor);
   //     }
   //   }
   // }
    //class SwitchDemo {
    //    static void Main() {
    //        int i;

    //        for (i = 0; i < 10; i++)
    //        switch (i){
    //                case 0:
    //                    Console.WriteLine("i equals zero");
    //                    break;
    //                case 1:
    //                    Console.WriteLine("i equals 1");
    //                    break;
    //                case 2:
    //                    Console.WriteLine("i equals 2");
    //                    break;
    //                case 3:
    //                    Console.WriteLine("i equals 3");
    //                    break;
    //                case 4:
    //                    Console.WriteLine("i equals 4");
    //                    break;
    //                default:
    //                    Console.WriteLine("i equals 5 or greater");
    //                    break;
    //            }
    //    }
    //}
    //class NoZeroDiv { 
    //static void Main() {

    //        for (int i = -5; i < 6; i++)
    //        {
    //            if (i != 0 ? (i % 2 == 0) : false)
    //                Console.WriteLine("100 / " + i + " equals " + 100 / i);
    //        }
    //        //int result;
    //        //for (int i = -5; i < 6; i++)
    //        //{
    //        //    result = i != 0 ? 100 / i : 0;
    //        //    if (i!=0)
    //        //    {
    //        //        Console.WriteLine("100 / " + i + " equals " + result);
    //        //    }
    //        //}
    //    }
    //}
    //class PrePostDemo { 
    //static void Main()
    //    {
    //        int x, y;
    //        int i;

    //        x = 1;
    //        y = 0;
    //        Console.WriteLine("Number of digits received" + "with helping operator y = y + x++;");
    //        for (i = 0; i < 10; i++)
    //        {
    //            y = y + x++;
    //            Console.WriteLine(y + " ");
    //        }
    //        Console.WriteLine();

    //        x = 1;
    //        y = 0;

    //        Console.WriteLine("Number of digits received" + "with helping operator y = y+ ++x;");
    //        for (i = 0; i < 10; i++)
    //            {
    //                y = y + ++x;

    //                Console.WriteLine(y + " ");
    //            }
    //        }
    //    }
    //class CastExpr {
    //    static void Main()
    //    {
    //        double n;

    //        for (n = 1.0; n <= 10; n++)
    //        {
    //            Console.WriteLine("Квадратный корень из {0} равен {1}", n, Math.Sqrt(n));
    //            Console.WriteLine("d: {0}", (int)Math.Sqrt(n));
    //            Console.WriteLine("Дробная часть числа: {0}", Math.Sqrt(n) - (int)Math.Sqrt(n));
    //        }
    //    }
    //}
    //class ScopeDemo {

    //    static void Main() {
    //        int x;
    //        x = 10;
    //        if (x == 10)
    //        {
    //            int y = 20;
    //            x = y * 2;
    //        }
    //        Console.WriteLine("x equals " + x);
    //    }
    //}
    //class DisplayOptions {
    //    static void Main()
    //    {
    //        int i;
    //        Console.WriteLine("Number/Square/Cube");
    //        for (i = 1; i < 10; i++)
    //            Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double radius; //test variable
    //        double area; //test variable

    //        radius = 10.0;
    //        area = radius * radius * 3.1416;

    //        Console.WriteLine("Area is equal: " + area);
    //        Earth();
    //    }

    //    static void Earth()
    //    {
    //        long inches;
    //        long miles;

    //        miles = 93000000;
    //        inches = miles * 5280 * 12;
    //        Console.WriteLine("Distance to sun: " + inches);
    //    }
    //}

    //class Use_byte {
    //    static void Main() 
    //    {
    //        byte x;
    //        int sum;
    //        sum = 0;
    //        for (x = 1; x <= 100; x++)
    //            sum = sum + x;

    //        Console.WriteLine("Sum from 1 to 100 is equal: " + sum);
    //   }
    //}

    //class NestVar
    //{
    //    static void Main()
    //    {
    //        int count;

    //        for (count = 0; count < 10; count = count + 1)
    //        {
    //            Console.WriteLine("Something: " + count);

    //            int count;
    //            for (count = 0; count < 2; count++)
    //                Console.WriteLine("Issue appears here");
    //        }
    //    }
    //}
}
