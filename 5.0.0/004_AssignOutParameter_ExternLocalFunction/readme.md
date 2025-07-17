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

## `CS0177` is not reported on method with unassigned `out` parameter when calling `extern` local function

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class C
    {
        void M(out int i)
        {
            f();

            static extern void f();
        }
    }
    ```

### Expected Behavior

`CS0177` is reported on `M`.

### Actual Behavior

It is not.
