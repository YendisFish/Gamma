using Gamma.Types;
using Gamma.Native;

using System.Runtime.InteropServices;

namespace Gamma;

public unsafe class LibImporter : IDisposable
{
    internal string path { get; set; }
    internal IntPtr libHandle { get; set; }

    public LibImporter(string filename)
    {
        path = new FileInfo(filename).FullName;

        #pragma warning disable CA1416
        libHandle = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? NativeFunctions.LoadLibrary(path) : NativeFunctions.dlopen(path, 2);
        #pragma warning restore CA1416

        if(libHandle == IntPtr.Zero)
        {
            throw new Exception($"Could not load library: {filename}");
        }
    }

    public NativeDelegate LoadFunction(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public NativeDelegate<T> LoadFunction<T>(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public NativeDelegate<T, TA1> LoadFunction<T, TA1>(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public NativeDelegate<T, TA1, TA2> LoadFunction<T, TA1, TA2>(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public NativeDelegate<T, TA1, TA2, TA3> LoadFunction<T, TA1, TA2, TA3>(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public NativeDelegate<T, TA1, TA2, TA3, TA4> LoadFunction<T, TA1, TA2, TA3, TA4>(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public NativeDelegate<T, TA1, TA2, TA3, TA4, TA5> LoadFunction<T, TA1, TA2, TA3, TA4, TA5>(string symbol)
    {
        #pragma warning disable CA1416
        return new((RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) ? NativeFunctions.GetProcAddress(libHandle, symbol) : NativeFunctions.dlsym(libHandle, symbol));
        #pragma warning restore CA1416
    }

    public void Dispose()
    {
        #pragma warning disable CA1416
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) { NativeFunctions.FreeLibrary(libHandle); } else { NativeFunctions.dlclose(libHandle); }
        #pragma warning restore CA1416
    }

    ~LibImporter()
    {
        #pragma warning disable CA1416
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) { NativeFunctions.FreeLibrary(libHandle); } else { NativeFunctions.dlclose(libHandle); }
        #pragma warning restore CA1416
    }
}