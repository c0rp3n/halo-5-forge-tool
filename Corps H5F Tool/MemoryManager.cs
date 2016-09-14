using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Corps_H5F_Tool
{
    class MemoryManager
    {
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        public static int H5Fpid = (int)UWP.LaunchApp("Microsoft.Halo5Forge_1.114.4592.2_x64__8wekyb3d8bbwe");

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        public static void WriteToAddress(Int32 address, byte[] hex)
        {
            Process p = Process.GetProcessesByName("halo5forge").FirstOrDefault();
            Int64 startOffset = p.MainModule.BaseAddress.ToInt64();
            Int64 offset = startOffset + address;
            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
            int unused = 0;
            IntPtr addr = new IntPtr(offset);
            WriteProcessMemory(hProc, addr, hex, (UInt32)hex.LongLength, out unused);

            CloseHandle(hProc);
        }

        public static byte[] ReadFromAddress(Int32 address)
        {
            Process p = Process.GetProcessesByName("halo5forge").FirstOrDefault();
            Int64 startOffset = p.MainModule.BaseAddress.ToInt64();
            Int64 offset = startOffset + address;
            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
            int unused = 0;
            IntPtr addr = new IntPtr(offset);
            byte[] hex = new byte[4];
            ReadProcessMemory(hProc, addr, hex, (UInt32)hex.LongLength, ref unused);
            return hex;
        }
    }

    class UWP // Taken from http://blogs.microsoft.co.il/pavely/2015/10/24/launching-windows-store-apps-programmatically/ Credit goes to Pavel.
    {
        enum ActivateOptions
        {
            None = 0x00000000,  // No flags set
            DesignMode = 0x00000001,  // The application is being activated for design mode
            NoErrorUI = 0x00000002,  // Do not show an error dialog if the app fails to activate                                
            NoSplashScreen = 0x00000004,  // Do not show the splash screen when activating the app
        }

        [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("2e941141-7f97-4756-ba1d-9decde894a3d")]
        interface IApplicationActivationManager
        {
            int ActivateApplication([MarshalAs(UnmanagedType.LPWStr)] string appUserModelId, [MarshalAs(UnmanagedType.LPWStr)] string arguments,
                ActivateOptions options, out uint processId);
            int ActivateForFile([MarshalAs(UnmanagedType.LPWStr)] string appUserModelId, IntPtr pShelItemArray,
                [MarshalAs(UnmanagedType.LPWStr)] string verb, out uint processId);
            int ActivateForProtocol([MarshalAs(UnmanagedType.LPWStr)] string appUserModelId, IntPtr pShelItemArray,
                [MarshalAs(UnmanagedType.LPWStr)] string verb, out uint processId);
        }

        [ComImport, Guid("45BA127D-10A8-46EA-8AB7-56EA9078943C")]
        class ApplicationActivationManager { }

        [DllImport("kernel32")]
        static extern int OpenPackageInfoByFullName([MarshalAs(UnmanagedType.LPWStr)] string fullName, uint reserved, out IntPtr packageInfo);

        [DllImport("kernel32")]
        static extern int GetPackageApplicationIds(IntPtr pir, ref int bufferLength, byte[] buffer, out int count);

        [DllImport("kernel32")]
        static extern int ClosePackageInfo(IntPtr pir);

        public static uint LaunchApp(string packageFullName, string arguments = null)
        {
            IntPtr pir = IntPtr.Zero;
            OpenPackageInfoByFullName(packageFullName, 0, out pir);

            int length = 0, count;
            GetPackageApplicationIds(pir, ref length, null, out count);

            var buffer = new byte[length];
            GetPackageApplicationIds(pir, ref length, buffer, out count);

            var appUserModelId = Encoding.Unicode.GetString(buffer, IntPtr.Size * count, length - IntPtr.Size * count);
            var activation = (IApplicationActivationManager)new ApplicationActivationManager();
            uint pid;
            int hr = activation.ActivateApplication(appUserModelId, arguments ?? string.Empty, ActivateOptions.NoErrorUI, out pid);
            if (hr < 0)
                Marshal.ThrowExceptionForHR(hr);
            return pid;
        }
    }
}
