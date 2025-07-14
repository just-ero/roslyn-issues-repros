> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-1.25263.3  
> **.NET SDK**: 10.0.100-preview.4.25258.110  
>  
> **Visual Studio Code**: 1.100.2  
> **C# Extension**: 2.78.15  
> **C# Dev Kit Extension**: 1.20.4  

## [Cannot rename generic parameter with `new()` constraint on instantiation](https://github.com/dotnet/roslyn/issues/78649)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class C<T> where T : new()
    {
        void M()
        {
            _ = new T();
        }
    }
    ```
2. Attempt to rename `T` specifically on the `new T()` instantiation.

### Expected Behavior

The generic parameter can be renamed.

### Actual Behavior

It cannot.

It can be renamed without issue on all other occurrences of `T` in the repro.
