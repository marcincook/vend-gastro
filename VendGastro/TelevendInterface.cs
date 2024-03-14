using System.Runtime.InteropServices;

public class TelevendInterface
{
    const string DLL_PATH = "TelevendPOS.dll";
    //const string DLL_PATH = "C:\\Users\\marci\\source\\repos\\marcincook\\vend-gastro\\VendGastro\\libs\\TelevendPOS.dll";

    //[DllImport(DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendInit(int numerPortuSzeregowego, VendGastro.TelevendCallbackHandler.TelevendCallback callback);

    // Definicja funkcji zwrotnej
    //public delegate void TelevendCallback(int result);

    //public delegate void TelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID);


    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern void TelevendDeinit();


    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendStatus();

    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendGetPricingGroup(out uint AvailableCredit, out ulong CardID);


    [DllImport(DLL_PATH, CallingConvention = CallingConvention.StdCall)]
    public static extern int TelevendRequest(int amount);
}
