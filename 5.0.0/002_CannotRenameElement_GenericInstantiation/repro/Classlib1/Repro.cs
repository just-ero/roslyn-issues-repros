namespace Classlib1;

class C<T>
    where T : new()
{
    void M()
    {
        _ = new T();
    }
}
