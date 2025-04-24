> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-1.25204.1  
> **.NET SDK**: 10.0.100-preview.2.25164.34  
>  
> **Visual Studio Code**: 1.99.3  
> **C# Extension**: 2.74.24  
> **C# Dev Kit Extension**: 1.19.35  

## [Spread element does not emit nullability warning when converting to certain collection types](https://github.com/dotnet/roslyn/issues/78307)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    List<string> Repro()
    {
        string?[] arr = [];
        return [.. arr];
    }
    ```

### Expected Behavior

`[.. list]` emits `CS8601` (`Possible null reference assignment.`).

### Actual Behavior

It does not.  
This is the case for `List<T>` and `HashSet<T>`. Other collection types may also be affected.

When the target collection type is `T[]` or `IEnumerable<T>`, the warning is produced as expected.
