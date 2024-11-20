namespace Classlib1;

abstract class A
{
    public abstract void M();
}

// Repro: Apply `Implement abstract class` fix on `B`.
class B : A

file class C;
