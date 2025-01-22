> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-1.25060.2  
> **.NET SDK**: 9.0.102  
>  
> **Visual Studio Code**: 1.96.4  
> **C# Extension**: v2.62.18  
> **C# Dev Kit Extension**: v1.16.4  

## [Fix `Use 'new(...)'` is only suggested for expression-bodied members](https://github.com/dotnet/roslyn/issues/)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class C
    {
        static C Repro1() => new C();
    
        static C Repro2()
        {
            return new C();
        }
    }
    ```

### Expected Behavior

`IDE0090` is emitted on both `Repro1` and `Repro2`.

### Actual Behavior

`IDE0090` is only emitted on `Repro1`.
