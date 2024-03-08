using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class TelevendInterface
{
    const string DLL_PATH = "TelevendPOS.dll";
    //const string DLL_PATH = "C:\\Users\\marci\\source\\repos\\marcincook\\vend-gastro\\VendGastro\\libs\\TelevendPOS.dll";

    //[DllImport(DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendInit(int numerPortuSzeregowego, TelevendCallback zwrotFunkcji);

    // Definicja funkcji zwrotnej
    public delegate void TelevendCallback(int result);

    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern void TelevendDeinit();


    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendStatus();

    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendGetPricingGroup(out uint AvailableCredit, out uint CardID);
}
