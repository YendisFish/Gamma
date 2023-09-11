# Prism
With C#s incredibly disappointing support for
importing unmanaged libraries, I have decided
to write a wrapper to import and marshal unmanaged
types into managed code. In other words, I
would like to introduce Prism! An all new, niche
library I am working on to interop with native
libraries.

# Supported Platforms
Prism supports both Windows and Linux, with
hopeful future support for OSX!

Keep in mind that on linux, Prism needs the
C standard libraries to be installed to run!

# Dependencies
- Windows: <a href="https://visualstudio.microsoft.com/vs/">Visual Studio Community 2022</a> (Make sure to download the C/C++ tools!) (Or your C compiler of choice)
- Linux: GCC (or your C compiler of choice)

# Getting Started
First lets write our C program!

mylib.c
```c
//Linux
int GetInt()
{
    return 5;
}

//Windows
__declspec(dllexport) int GetInt()
{
    return 5;
}
```

Now we compile:

Windows (Keep in mind your DLL needs to be for the same architecture as your C# program! See [here](/Issues/THEWINDOWSPROBLEM.md)):

Open x64 Native Tools Command Prompt for VS 2022 (You can literally just search for this in Windows)(Why in the world does this have such a long name?)

Now type:
```bash
cl /LD mylib.c
```

Linux:
```sh
gcc mylib.c -o libmylib.o
gcc mylib.o -shared -o libmylib.so
```

And now we are ready to create our C#!

Windows:
```cs
using(Importer import = new Importer("mylib.dll"))
{
    NativeDelegate<int> getint = import.LoadFunc("GetInt");
    int foo = getint.Invoke();

    Console.WriteLine(foo);
}
```

Linux:
```cs
using(Importer import = new Importer("libmylib.so"))
{
    NativeDelegate<int> getint = import.LoadFunc("GetInt");
    int foo = getint.Invoke();

    Console.WriteLine(foo);
}
```
# As Seen In
- <a href="https://github.com/grimtin10/Rainbow/">Rainbow (Grimtin10, YendisFish)</a>