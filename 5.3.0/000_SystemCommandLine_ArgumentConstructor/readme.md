> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.3.0-1.25514.3 (225ca710)  
> **.NET SDK**: 10.0.100-rc.2.25502.107  
>  
> **Visual Studio Code**: 1.105.1  
> **C# Extension**: 2.96.3  
> **C# Dev Kit Extension**: 1.73.8  

## [Constructor overload is unresolved despite being present when navigating to definition](https://github.com/dotnet/roslyn/issues/80882)

### Steps to Reproduce

1. Add a reference to `System.CommandLine`: `dotnet add package System.CommandLine --prerelease`
2. Add the following code to `Program.cs`: `var arg = new System.CommandLine.Argument<int>("name", "description")`
3. Observe `'Argument<int>' does not contain a constructor that takes 2 arguments` on the constructor call
4. Navigate to `System.CommandLine.Argument<T>`'s definition to find the following constructor:
    ```cs
    public Argument(
        string? name, 
        string? description = null) : base(name, description)
    {
    }
    ```

### Expected Behavior

The overload is either correctly resolved, or the definition does not show the constructor.

### Actual Behavior

The overload is unresolved, or the definition is wrong.
