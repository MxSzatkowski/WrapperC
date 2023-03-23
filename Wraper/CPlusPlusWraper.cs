using System;
using System.Runtime.InteropServices;

namespace Wrapper
{
  public class CPlusPlusWraper
    {
        public const string DllPath = @"..\..\..\..\x64\Debug\CPlusPlus.dll";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(int a, int b);
        public void UseAddNumbers()
        { 
        int output = AddNumbers(10, 20);
        Console.WriteLine($"Result: {output}");
        }
    }
}
