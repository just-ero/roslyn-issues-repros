namespace Classlib1;

struct S
{
    // IDE0251: `Member can be made 'readonly'`
    void CounterExample() { }

    // No suggestion.
    void Repro() => throw new();
}
