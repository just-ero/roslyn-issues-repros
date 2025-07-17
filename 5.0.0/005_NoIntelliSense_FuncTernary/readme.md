> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-1.25361.2 (fdd628a8)  
> **.NET SDK**: 10.0.100-preview.6.25358.103  
>  
> **Visual Studio Code**: 1.102.1  
> **C# Extension**: 2.86.19  
> **C# Dev Kit Extension**: 1.40.25  

## [No IntelliSense in lambda body of ternary consequent expression when ternary alternative expression is missing or invalid](https://github.com/dotnet/roslyn/issues/79443)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    void M()
    {
        Func<int, string> f = true
            ? (i => i.ToString())
            : (i => );
    }
    ```
    Note: Any invalid alternative expression results in the behavior.
2. Hover over `i.ToString()` to see no IntelliSense.

### Expected Behavior

The consequent expression is correctly recognized, IntelliSense is offered, and code has semantic highlighting.

### Actual Behavior

It does not.
