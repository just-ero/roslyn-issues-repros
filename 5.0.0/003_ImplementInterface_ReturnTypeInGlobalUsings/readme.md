> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.0.0-1.25319.11  
> **.NET SDK**: 10.0.100-preview.5.25277.114  
>  
> **Visual Studio Code**: 1.102.0  
> **C# Extension**: 2.84.19  
> **C# Dev Kit Extension**: 1.30.44  

## [Implementing interface (or abstract class) whose members reference a type included via a global import adds empty line to the beginning of file](https://github.com/dotnet/roslyn/issues/79363)

### Steps to Reproduce

1. Add the following code in separate files:
    ```cs
    namespace N;

    class C;
    ```
    ```cs
    interface II
    {
        C M();
    }
    ```
    ```cs
    class Repro : II;
    ```
   Note: `C` must be in a different namespace than `II` and `Repro`, and `Repro` must not know of `C` before implemetation.
2. Add `N` to the global usings anywhere.
3. Apply the `Implement interface` quick fix to `Repro`.

### Expected Behavior

No new line is added to the beginning of the file.

### Actual Behavior

It is.

Speculation: this is possibly due to Roslyn making an attempt to add missing namespaces, but stopping after finding the global import.
