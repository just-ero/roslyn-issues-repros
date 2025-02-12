namespace Classlib1;

class C
{
    void M1(bool b1)
    {
        // Repro: Apply `Invert if`.
        if (
            b1) { }
    }

    void M2(bool b1, bool b2)
    {
        // Repro: Apply `Invert if`.
        if (b1 &&
            b2) { }
    }
}
