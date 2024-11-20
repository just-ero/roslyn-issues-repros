> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 4.13.0-2.24565.3  
> **.NET SDK**: 9.0.100  
>  
> **Visual Studio Code**: 1.95.3  
> **C# Extension**: v2.57.28  
> **C# Dev Kit Extension**: v1.14.8  

## [Fix `Implement abstract class` generates invalid code when target type has no body and is followed by file-scoped type](https://github.com/dotnet/roslyn/issues/)

### Steps to Reproduce

1. Add the following code wherever syntactically applicable:
   ```cs
   abstract class A
   {
       public abstract void M();
   }
   
   class B : A
   
   file class C;
   ```
2. Apply the `Implement abstract class` fix on `B`.

### Expected Behavior

```cs
abstract class A
{
    public abstract void M();
}

class B : A
{
    public override void M()
    {
        throw new System.NotImplementedException();
    }
}

file class C;
```

### Actual Behavior

```cs
abstract class A
{
    public abstract void M();
}

class B : A

file
{
    public override void M()
    {
        throw new System.NotImplementedException();
    }
}

class C;
```
