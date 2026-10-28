using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPrintable
    {
        void Print();
        string GetSummary();   // every implementor must define this
    }
}