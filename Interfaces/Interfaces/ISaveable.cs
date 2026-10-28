using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ISaveable
    {
        void SaveToFile(string path);
        bool LoadFromFile(string path);
    }
}
