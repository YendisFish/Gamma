using System.Runtime.InteropServices;
using Prism;
using Prism.Types;

if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    using (LibImporter import = new LibImporter("../../Native/winlib.dll"))
    {
        NativeDelegate<int> GetInt = import.LoadFunction<int>("GetInt");
        int x = GetInt.Invoke();

        Console.WriteLine(x);
    }
} else {
    using (LibImporter import = new LibImporter("../../Native/library.so"))
    {
        NativeDelegate<int> GetInt = import.LoadFunction<int>("GetInt");
        int x = GetInt.Invoke();

        Console.WriteLine(x);
    }
}