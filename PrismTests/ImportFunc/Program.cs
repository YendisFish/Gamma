using System.Runtime.InteropServices;
using Prism;
using Prism.Types;

if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    using (Importer import = new Importer("../../Native/winlib.dll"))
    {
        NativeDelegate<int> GetInt = import.LoadFunction<int>("GetInt");
        int x = GetInt.Invoke();

        Console.WriteLine(x);
    }
} else {
    using (Importer import = new Importer("../../Native/library.so"))
    {
        NativeDelegate<int> GetInt = import.LoadFunction<int>("GetInt");
        int x = GetInt.Invoke();

        Console.WriteLine(x);
    }
}