namespace Classlib1;

enum E;

static class EExt
{
    extension(E)
    {
        public static void M() { }
    }
}

class C
{
    void M()
    {
        // Repro: Type `E.`. `M` is not suggested.
        E.
    }
}
