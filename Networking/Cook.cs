using System;
using System.Collections;
using System.Net;

//Cook is responsible for Network Discovery and Enumeration

namespace Networking
{
    internal class Cook
    {
        public void Enumerate()
        {
            ArrayList alNetworkComputers =
                NetApi32.GetServerList(NetApi32.SV_101_TYPES.SV_TYPE_WORKSTATION | NetApi32.SV_101_TYPES.SV_TYPE_SERVER);

            for (int nIndex = 0; nIndex < alNetworkComputers.Count; nIndex++)
            {
                string computerName = ((NetApi32.SERVER_INFO_101) alNetworkComputers[nIndex]).sv101_name;
                Console.WriteLine(Dns.GetHostAddresses(computerName)[0] + "\t\t : \t" + computerName);
            }
            Console.ReadLine();
        }
    }
}