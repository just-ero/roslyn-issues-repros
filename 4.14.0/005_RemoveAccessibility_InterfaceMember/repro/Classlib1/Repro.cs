namespace Classlib1;

public interface IInterface
{
    // Repro: `Accessibility modifiers required` is reported.
    public void M();
}
