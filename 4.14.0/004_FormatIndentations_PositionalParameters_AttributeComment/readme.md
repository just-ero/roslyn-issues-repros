> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-2.25106.12  
> **.NET SDK**: 9.0.200  
>  
> **Visual Studio Code**: 1.97.1  
> **C# Extension**: 2.65.29  
> **C# Dev Kit Extension**: 1.17.12  

## No formatting of indentation on positional parameter if line above contains attribute and comment

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class AAttribute : Attribute;

    record R(
        [A] // Comment.
    	int I);
    ```
   Note: The line with the attribute and the comment is indented with 4 spaces. The line with the positional parameter is indented with 1 tab.
2. Apply the `Format document` action.  
   Note: The document's indentations should be set to 4 spaces.

### Expected Behavior

The indentation on the line with the positional parameter is changed to that of the overall document's.

### Actual Behavior

It is not.  
The same problem occurs for `class` primary constructors.
