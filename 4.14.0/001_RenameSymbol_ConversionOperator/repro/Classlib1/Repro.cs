namespace Classlib1;

class C;

class Repro1
{
    // Repro: Apply `Rename symbol` to `Repro1`.
    public static explicit operator Repro1(C _)
    {
        return null;
    }
}

class Repro2<T>
{
    // Repro: Apply `Rename symbol` to `Repro2`.
    public static explicit operator Repro2<T>(T _)
    {
        return null;
    }
}
