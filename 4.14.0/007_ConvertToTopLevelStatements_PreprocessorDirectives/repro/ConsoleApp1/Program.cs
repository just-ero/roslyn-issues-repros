using System;

namespace ConsoleApp1;

class Program
{
    // Repro: Apply `Convert to top-level statements`.
    static void Main()
    {
#if true
        Console.WriteLine("true");
#else
        Console.WriteLine("false");
#endif
    }
}

// class Program
// {
//     // Repro: Apply `Convert to top-level statements`.
//     static void Main()
//     {
// #if false
//         Console.WriteLine("false");
// #else
//         Console.WriteLine("true");
// #endif
//     }
// }
