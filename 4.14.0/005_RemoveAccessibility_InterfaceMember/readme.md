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

## "Accessibility modifiers required" reported on interface member with accessibility modifier when `IDE0040` option is `for_non_interface_members`

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    public interface IInterface
    {
        public void M();
    }
    ```
2. Set `dotnet_style_require_accessibility_modifiers`'s option to `for_non_interface_members` and its severity to `suggestion` or higher.
3. Observe `IDE0040` on `IInterface.M`.

### Expected Behavior

The diagnostic suggests the removal of the accessibility modifier.

### Actual Behavior

The diagnostic suggests the addition of the accessibility modifier.
