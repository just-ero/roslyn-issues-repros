> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-1.25204.1  
> **.NET SDK**: 10.0.100-preview.2.25164.34  
>  
> **Visual Studio Code**: 1.99.1  
> **C# Extension**: 2.73.16  
> **C# Dev Kit Extension**: 1.19.4  

## Suppression via preprocessor directive is considered unnecessary for some diagnostics

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    #pragma warning disable SYSLIB1054

    class C
    {
        [DllImport("_")]
        static extern void M();
    }
    ```
2. Target .NET 7.0 or higher.

### Expected Behavior

The suppression of `SYSLIB1054` is not considered unnecessary.

### Actual Behavior

It is.
