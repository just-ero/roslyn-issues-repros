> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-3.25178.1  
> **.NET SDK**: 9.0.202  
>  
> **Visual Studio Code**: 1.99.0  
> **C# Extension**: 2.72.22  
> **C# Dev Kit Extension**: 1.18.16  

## "Convert to top-level statements" does not correctly handle code excluded by conditional preprocessor directive

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class Program
    {
        static void Main()
        {
    #if true
            Console.WriteLine("true");
    #else
            Console.WriteLine("false");
    #endif
        }
    }
    ```
   or:
    ```cs
    class Program
    {
        static void Main()
        {
    #if false
            Console.WriteLine("false");
    #else
            Console.WriteLine("true");
    #endif
        }
    }
    ```
2. Apply "Convert to top-level statements" on `Main`.

### Expected Behavior

```cs
#if true
    Console.WriteLine("true");
#else
    Console.WriteLine("false");
#endif
```
and
```cs
#if false
    Console.WriteLine("false");
#else
    Console.WriteLine("true");
#endif
```
respectively.

### Actual Behavior

```cs
#if true
    Console.WriteLine("true");
```
and
```cs
#if false
        Console.WriteLine("false");
#else
Console.WriteLine("true");
```
respectively.
