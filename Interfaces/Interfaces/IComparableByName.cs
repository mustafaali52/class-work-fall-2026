using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IComparableByName
    {
        int CompareByName(object other);

        // Default interface method (C# 8+ / .NET 10)
        bool NameStartsWith(string prefix) => GetSummary().StartsWith(prefix);
        string GetSummary();   // still abstract — must be implemented

    }
}
