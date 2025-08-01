> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-2.25371.17 (ce148ddd)  
> **.NET SDK**: 10.0.100-preview.6.25358.103  
>  
> **Visual Studio Code**: 1.102.2  
> **C# Extension**: 2.87.26  
> **C# Dev Kit Extension**: 1.41.5  

## Fix `Use auto property` formats code incorrectly when attribute is applied to accessor

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class AAttribute : Attribute;

    class C
    {
        int _i;
        int I
        {
            [A]
            get => _i;
        }
    }
    ```
2. Apply `Use auto property` on `_i`.

### Expected Behavior

```cs
int I
{
    [A]
    get;
}
```
or
```cs
int I { [A] get; }
```

### Actual Behavior

```cs
int I { [A]
    get; }
```
