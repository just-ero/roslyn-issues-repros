#nullable enable

using System.Collections.Generic;

namespace Classlib1;

class C
{
    List<string> Repro()
    {
        string?[] arr1 = [];
        return [.. arr1];
    }
}
