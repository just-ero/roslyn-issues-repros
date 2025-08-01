using System;

namespace Classlib1;

class C
{
    void M(string s) { }
    void M(Action a) { }

    void Repro1(int i)
    {
        // Repro: Add a comma anywhere in the switch arms.
        M(i switch
        {
            0 => ""
        });
    }

    void Repro2()
    {
        // Repro: Add a comma anywhere in the action's body.
        M(() => { });
    }
}
