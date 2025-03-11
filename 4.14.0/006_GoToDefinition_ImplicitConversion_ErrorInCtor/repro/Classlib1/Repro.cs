namespace Classlib1;

record R(int I);

class C
{
    public C Repro()
    {
        // Repro: Use `Go to definition` on `R`.
        M(new R(1u));

        // Repro: Use `Go to definition` on `R`.
        return new R(1u);
    }

    public static void M(C c) { }

    public static implicit operator C(R r)
    {
        return new();
    }
}
