namespace Classlib1;

class C
{
    void M()
    {
        // Repro: Hover over `i.ToString()`.
        Func<int, string> repro = true
            ? (i => i.ToString())
            : (i => );
    }
}
