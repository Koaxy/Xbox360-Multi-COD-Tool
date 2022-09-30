using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRPCLib;
using XboxCore.Xbox.Connection;

using Xbox_Modding.Classes;
using XDevkit;


namespace Xbox_Modding.Classes
{
    public partial class ZombieClass
    {

        public static XRPC XRPC = new XRPC();
        public static IXboxConsole ginterFace;
        public static IXboxConsole ginterFaceout;
        public const uint conSoleAddr = 0x8230FD58;
        public static void CallConsoleCommand(string Command)
        {
            XRPC.Call(conSoleAddr, 0, Command);
        }

        public static void CheckForConnection()
        {
            if (ginterFace == null || XRPC.activeConnection == false)
            {
                Console.WriteLine("Console Not connected!");
                return;
            }
        }

    }
}
