> [!IMPORTANT]  
> The following repro was done on Visual Studio Code.  
> Visual Studio was not tested.  

> [!NOTE]  
> **Roslyn**: 5.3.0-2.25604.5 (663927dce6fab99b76b051aa5b99b0a53e8ed515)  
> **.NET SDK**: 10.0.101  
>  
> **Visual Studio Code**: 1.108.0  
> **C# Extension**: 2.111.2  
> **C# Dev Kit Extension**: 1.91.6  

## Throwing member in struct does not emit `can be made 'readonly'`

### Steps to Reproduce

1. ```cs
   struct S
   {
       void M() => throw null;
   }
   ```

### Expected Behavior

`S.M` emits IDE0251.

### Actual Behavior

It does not.
