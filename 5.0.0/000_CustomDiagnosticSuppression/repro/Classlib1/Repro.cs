// Repro: Comment in the below line. The suppression is considered unnecessary.
// #pragma warning disable SYSLIB1054

using System.Runtime.InteropServices;

namespace Classlib1;

class C
{
    [DllImport("_")]
    static extern void Repro(); // SYSLIB1054
}
