namespace Classlib1;

class C
{
    // Repro: `'new' expression can be simplified` is emitted.
    static C Repro1() => new C();

    static C Repro2()
    {
        // Repro: `'new' expression can be simplified` is not emitted.
        return new C();
    }
}
