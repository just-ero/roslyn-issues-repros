namespace Classlib1;

class C
{
    void Repro(out int i)
    {
        f();

        static extern void f();
    }
}
