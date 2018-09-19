using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImc.Domain.Interfaces
{
   public interface IDatabaseFile
    {
        string GetFilePath(string file);
    }
}
