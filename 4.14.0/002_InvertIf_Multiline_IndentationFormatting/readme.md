> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.14.0-1.25074.7  
> **.NET SDK**: 9.0.102  
>  
> **Visual Studio Code**: 1.97.1  
> **C# Extension**: v2.64.7  
> **C# Dev Kit Extension**: v1.17.4  

## `Invert if` results in incorrect formatting when applied to multi-line `if`-statement

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
    ```cs
    class C
    {
        void M1(bool b1)
        {
            if (
                b1) { }
        }

        void M2(bool b1, bool b2)
        {
            if (b1 &&
                b2) { }
        }
    }
    ```
2. Apply the `Invert if` action on the `if`-statements.

### Expected Behavior

```cs
class C
{
    void M1(bool b1)
    {
        if (
            !b1) { }

        // or

        if (!b1) { }
    }

    void M2(bool b1, bool b2)
    {
        if (!b1 ||
            !b2) { }
    }
}
```

### Actual Behavior

```cs
class C
{
    void M1(bool b1)
    {
        if (
!b1) { }
    }

    void M2(bool b1, bool b2)
    {
        if (!b1 ||
!b2) { }
    }
}
```
