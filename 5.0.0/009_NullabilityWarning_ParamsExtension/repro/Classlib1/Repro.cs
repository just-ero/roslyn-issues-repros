namespace Classlib1;

class C;

static class E
{
    extension(C)
    {
        static void Extension(params C[] values) { }
    }

    static void Repro()
    {
        C.Extension(new C());
    }
}
