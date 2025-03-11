> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-2.25120.5  
> **.NET SDK**: 9.0.200  
>  
> **Visual Studio Code**: 1.98.1  
> **C# Extension**: 2.68.46  
> **C# Dev Kit Extension**: 1.17.48  

## ["Go to definition" on instantiation of source type navigates to implicit operator of target type when instantiation emits error](https://github.com/dotnet/roslyn/issues/77545)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    record R(int I);

    class C
    {
        public C Repro()
        {
            M(new R(1u));
            return new R(1u);
        }

        public static void M(C c) { }
        public static implicit operator C(R r)
        {
            return new();
        }
    }
    ```
2. Use "Go to definition" on the two instantiations of `R`.

### Expected Behavior

"Go to definition" should navigate to `R`.

### Actual Behavior

It navigates to the implicit operator on `C`.
