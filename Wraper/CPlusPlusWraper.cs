using System;
using System.Runtime.InteropServices;

namespace Wrapper
{
  public class CPlusPlusWraper
    {
        public const string DllPath = @"..\..\..\..\x64\Debug\Core.dll";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(int a, int b);
        public int UseAddNumbers(int a, int b)
        { 
        int output = AddNumbers(10, 20);
        Console.WriteLine($"Rsult {output}");
            return output;
        }

    }
}
