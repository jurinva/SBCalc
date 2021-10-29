using System;
﻿using System.IO;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
using System.Runtime.InteropServices;

namespace SBCalc
{
    public static class SBKLibrary
    {
        [DllImport("Pica_Func.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "?Encode@Pica@pica_lib@@SAHPADH0H@Z", ExactSpelling = true)]
        public unsafe static extern int Encode(byte* input, int isize, byte* output, int osize);
        public unsafe static int GetEncoder(string CPUID, ref string SBKCodeResult)
        {
            byte[] array = new byte[44];
            byte[] array2 = new byte[CPUID.Length];
            for (int i = 0; i < CPUID.Length; i++)
            {
                array2[i] = (byte)CPUID[i];
            }
            int result;
            fixed (byte* ptr = array)
            {
                fixed (byte* ptr2 = array2)
                {
                    result = SBKLibrary.Encode(ptr2, array2.Length, ptr, array.Length);
                    for (int j = 0; j < array.Length; j++)
                    {
                        SBKCodeResult += Convert.ToChar(array[j]);
                    }
                }
            }
            return result;
            // return 1;
        }
    }

}
