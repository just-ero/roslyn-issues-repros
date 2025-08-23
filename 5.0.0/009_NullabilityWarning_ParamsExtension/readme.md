> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-2.25412.5 (b0b21b61)  
> **.NET SDK**: 10.0.100-preview.7.25380.108  
>  
> **Visual Studio Code**: 1.103.2  
> **C# Extension**: 2.89.19  
> **C# Dev Kit Extension**: 1.50.20  

## `CS8620` reported on non-null argument passed to extension method with non-nullable params collection parameter

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class C;

    static class E
    {
        extension(C)
        {
            static void Extension(params C[] values) { }
        }

        static void M()
        {
            C.Extension(new C());
        }
    }
    ```
2. Observe `Argument of type 'C' cannot be used for parameter 'values' of type 'C[]' in 'void extension(C).Extension(params C[] values)' due to differences in the nullability of reference types.`

### Expected Behavior

The warning is not reported. The parameter expects non-nullable values and `new C()` is not nullable.

### Actual Behavior

It is.
