> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-1.25074.7  
> **.NET SDK**: 9.0.102  
>  
> **Visual Studio Code**: 1.97.1  
> **C# Extension**: 2.64.7  
> **C# Dev Kit Extension**: 1.17.4  

## Inserting line break in documentation comment results in new line being normal comment

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    /// <summary>
    /// Insert line break anywhere in this comment.
    /// </summary>
    class C;
    ```
2. Insert a line break anywhere in the documentation comment.  
   Note: The issue only appears when there are characters after the cursor when the line break is inserted. Adding the line break at the end of a line results in expected behavior.

### Expected Behavior

```cs
/// <summary>
/// Insert line break anywhere 
/// in this comment.
/// </summary>
class C;
```

### Actual Behavior

```cs
/// <summary>
/// Insert line break anywhere 
// in this comment.
/// </summary>
class C;
```
