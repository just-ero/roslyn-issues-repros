namespace Classlib1;

class AAttribute : System.Attribute;

class C
{
    // Repro: Apply `Use auto property`.
    int _i;

    int I
    {
        [A]
        get => _i;
    }
}
