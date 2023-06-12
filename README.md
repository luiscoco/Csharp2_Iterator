# Csharp2_Iterator

In C# version 2, iterators allow you to create a custom sequence of values that can be iterated over using a foreach loop. Iterators provide a convenient way to define and manipulate sequences without explicitly implementing the full IEnumerable and IEnumerator interfaces.

To create an iterator in C# version 2, you can use the yield keyword. The yield keyword enables you to define a sequence that is generated on-the-fly as you iterate over it, without needing to generate the entire sequence upfront.

Here's an example to illustrate how to use iterators in C# version 2:

```csharp
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        foreach (int number in GetNumbers())
        {
            Console.WriteLine(number);
        }
    }

    static IEnumerable GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
}
```

In the above code, the GetNumbers method is an iterator that returns a sequence of integers. It uses the yield keyword to define the values in the sequence. When the foreach loop iterates over the sequence, the GetNumbers method is invoked, and each yield return statement provides the next value in the sequence.

The output of the above code will be:
1
2
3

Iterators in C# version 2 are not as flexible as in later versions of C#, such as C# 2.0 and later, which introduced the yield return and yield break statements. These versions offer more powerful iterator functionality and make it easier to work with complex sequences and data structures.

Here's a more complex example that demonstrates how to use iterators in C# version 2 to generate a Fibonacci sequence:

```csharp
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
```

In this example, the FibonacciSequence method is an iterator that generates a Fibonacci sequence up to a specified count. It starts with the values 0 and 1, and then calculates subsequent Fibonacci numbers by adding the previous two numbers in the sequence.

The iterator uses the yield return statement to provide each Fibonacci number in the sequence. The yield return statement pauses the iterator and returns the current value to the foreach loop. When the loop requests the next value, the iterator resumes execution from where it left off, continuing the calculation and generating the next Fibonacci number.

The foreach loop in the Main method iterates over the Fibonacci sequence and prints each number to the console. The output of the above code will be the first 10 Fibonacci numbers:
0
1
1
2
3
5
8
13
21
34

This example demonstrates how you can use iterators to generate a sequence of values on-the-fly, without needing to pre-generate or store the entire sequence in memory.

