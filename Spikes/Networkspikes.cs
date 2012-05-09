using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices

namespace Spikes
{
    class Networkspikes
    {
        static List<string> GetComputersOnNetwork()
        {
            List<string> list = new List<string>();
            using (DirectoryEntry root = new DirectoryEntry("WinNT:"))
            {
                foreach (DirectoryEntry computers in root.Children)
                {
                    foreach (DirectoryEntry computer in computers.Children)
                    {
                        if ((computer.Name != "Schema"))
                        {
                            list.Add(computer.Name);
                        }
                    }
                }
            }
            return list;
        }
    }
}
