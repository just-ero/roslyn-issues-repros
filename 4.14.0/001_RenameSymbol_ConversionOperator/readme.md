> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-1.25074.7  
> **.NET SDK**: 9.0.102  
>  
> **Visual Studio Code**: 1.96.4  
> **C# Extension**: 2.64.7  
> **C# Dev Kit Extension**: 1.17.4  

## [`Rename symbol` does not work when applied on conversion operator return type](https://github.com/dotnet/roslyn/issues/77082)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class C;

    class Repro1
    {
        public static explicit operator Repro1(C _)
        {
            return null;
        }
    }

    class Repro2<T>
    {
        public static explicit operator Repro2<T>(T _)
        {
            return null;
        }
    }
    ```
2. Apply the `Rename symbol` action on the return type in the conversion operator declarations.

### Expected Behavior

The symbol is renamed everywhere.

### Actual Behavior

`Repro1`: Only the name in the operator declaration is renamed.  
`Repro2`: Nothing is renamed.
