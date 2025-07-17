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

## [Static extension members for `enum` type are not part of IntelliSense](https://github.com/dotnet/roslyn/issues/79444)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    enum E;

    static class EExt
    {
        extension(E)
        {
            public static void M() { }
        }
    }
    ```
2. Type `E.` to see suggested members. This can be in the same file.

### Expected Behavior

`M` is listed as a static method on `E`.

### Actual Behavior

It is not.
