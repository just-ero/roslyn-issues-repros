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

## Unexpected parameter info pop-up when typing certain tokens inside expression as argument

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    void M1(Action a) { }

    void M2()
    {
        M1(() => { });
    }
    ```
2. Type tokens like `,`, `{`, `(`, `[` anywhere in the lambda expression's block body.

### Expected Behavior

The parameter hint does not appear, because we're no longer in the argument context.

### Actual Behavior

It does.
