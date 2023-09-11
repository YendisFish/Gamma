using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Prism.Native;

public static class NativeFunctions
{
    [SupportedOSPlatform("Windows")]
    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    public static extern IntPtr LoadLibrary(string lpFileName);

    [SupportedOSPlatform("Windows")]
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [SupportedOSPlatform("Windows")]
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool FreeLibrary(IntPtr hModule);

    [SupportedOSPlatform("linux")]
    [DllImport("libdl.so.2", EntryPoint = "dlopen")]
    public static extern IntPtr dlopen(string filename, int flags);

    [SupportedOSPlatform("linux")]
    [DllImport("libdl.so.2", EntryPoint = "dlsym")]
    public static extern IntPtr dlsym(IntPtr handle, string symbol);

    [SupportedOSPlatform("linux")]
    [DllImport("libdl.so.2", EntryPoint = "dlclose")]
    public static extern int dlclose(IntPtr handle);
}