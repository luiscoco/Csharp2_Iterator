//using System;
//using System.Collections;

//class Program
//{
//    static void Main(string[] args)
//    {
//        foreach (int number in GetNumbers())
//        {
//            Console.WriteLine(number);
//        }
//    }

//    static IEnumerable GetNumbers()
//    {
//        yield return 1;
//        yield return 2;
//        yield return 3;
//    }
//}

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        foreach (int number in FibonacciSequence(10))
        {
            Console.WriteLine(number);
        }
    }

    static IEnumerable FibonacciSequence(int count)
    {
        int first = 0;
        int second = 1;

        yield return first;
        yield return second;

        for (int i = 2; i < count; i++)
        {
            int next = first + second;
            yield return next;

            first = second;
            second = next;
        }
    }
}



