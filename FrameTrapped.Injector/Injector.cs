using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Remoting;
using EasyHook;

namespace FrameTrapped.Injector
{
   public class Injector
    {
        static string ChannelName;
        public void inject()
        {
            int SF4Pid;
            Process[] procs = Process.GetProcessesByName("SSFIV");
            SF4Pid = procs[0].Id;           
            RemoteHooking.IpcCreateServer<SF4interface>(ref ChannelName, WellKnownObjectMode.Singleton);
            RemoteHooking.Inject(SF4Pid, InjectionOptions.DoNotRequireStrongName, "FrameTrapped.Injected.dll", "FrameTrapped.Injected.dll", ChannelName);
        }
    }

    public class SF4interface : MarshalByRefObject
    {
        public void IsInstalled(Int32 InClientPID)
        {
            return;
        }

        public void WriteConsole(String Write)
        {
            Console.WriteLine(Write);
        }

        private int _framenumber;

        public int FrameNumber
        {
            get
            {
                return _framenumber;
            }
            set
            {
                _framenumber = value;
                //raise event here
            }
        }

        public bool drawBasic1 = true; //Set these to enable/disable boxes
        public bool drawBasic2 = true;
        public bool drawProjectile1 = true;
        public bool drawProjectile2 = true;
        public bool drawProx1 = true;
        public bool drawProx2 = true;
        public bool drawHit1 = true;
        public bool drawHit2 = true;
        public bool drawGrab1 = true;
        public bool drawGrab2 = true;
        public bool drawInfo = true;
    }
}
