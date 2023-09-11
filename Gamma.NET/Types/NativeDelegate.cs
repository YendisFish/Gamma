using System.Runtime.InteropServices;

namespace Gamma.Types;

public unsafe struct NativeDelegate
{
    internal delegate*<void> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<void>)nativeFunc;
    }

    public void Invoke()
    {
        nativeFunc();
    }
}

public unsafe struct NativeDelegate<T>
{
    internal delegate*<T> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<T>)funcPtr;
    }

    public T Invoke()
    {
        return nativeFunc();
    }
}

public unsafe struct NativeDelegate<T, TARG1>
{
    internal delegate*<TARG1, T> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<TARG1, T>)nativeFunc;
    }

    public T Invoke(TARG1 arg1)
    {
        return nativeFunc(arg1);
    }
}

public unsafe struct NativeDelegate<T, TARG1, TARG2>
{
    internal delegate*<TARG1, TARG2, T> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<TARG1, TARG2, T>)nativeFunc;
    }

    public T Invoke(TARG1 arg1, TARG2 arg2)
    {
        return nativeFunc(arg1, arg2);
    }
}

public unsafe struct NativeDelegate<T, TARG1, TARG2, TARG3>
{
    internal delegate*<TARG1, TARG2, TARG3, T> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<TARG1, TARG2, TARG3, T>)nativeFunc;
    }

    public T Invoke(TARG1 arg1, TARG2 arg2, TARG3 arg3)
    {
        return nativeFunc(arg1, arg2, arg3);
    }
}

public unsafe struct NativeDelegate<T, TARG1, TARG2, TARG3, TARG4>
{
    internal delegate*<TARG1, TARG2, TARG3, TARG4, T> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<TARG1, TARG2, TARG3, TARG4, T>)nativeFunc;
    }

    public T Invoke(TARG1 arg1, TARG2 arg2, TARG3 arg3, TARG4 arg4)
    {
        return nativeFunc(arg1, arg2, arg3, arg4);
    }
}

public unsafe struct NativeDelegate<T, TARG1, TARG2, TARG3, TARG4, TARG5>
{
    internal delegate*<TARG1, TARG2, TARG3, TARG4, TARG5, T> nativeFunc { get; set; }

    public NativeDelegate(IntPtr funcPtr)
    {
        if(funcPtr == IntPtr.Zero)
        {
            throw new Exception($"Failed to load function from imported library!");
        }

        nativeFunc = (delegate*<TARG1, TARG2, TARG3, TARG4, TARG5, T>)nativeFunc;
    }

    public T Invoke(TARG1 arg1, TARG2 arg2, TARG3 arg3, TARG4 arg4, TARG5 arg5)
    {
        return nativeFunc(arg1, arg2, arg3, arg4, arg5);
    }
}