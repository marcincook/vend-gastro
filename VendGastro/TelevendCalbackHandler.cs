using System;

namespace VendGastro
{
    public class TelevendCallbackHandler
    {
        public delegate void TelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID);

        public static void OnTelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID)
        {
            // Handle the callback result
            switch (result)
            {
                case 0:
                    Console.WriteLine("Payment Approved");
                    break;
                case -1:
                    Console.WriteLine("Payment Authorization Timeout");
                    break;
                case -2:
                    Console.WriteLine("Payment Authorization Rejected - Not Enough Credit");
                    break;
                case -3:
                    Console.WriteLine("No Response from Televend Box (Local Communication Failure)");
                    break;
                case -4:
                    Console.WriteLine("Payment Canceled by User");
                    break;
                case -9:
                    Console.WriteLine("Payment Denied with Unspecified Reason");
                    break;
                default:
                    Console.WriteLine($"Unknown Result: {result}");
                    break;
            }

            // Handle additional information
            Console.WriteLine($"Payment Type: {paymentType}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Total Amount: {totalAmount}");
            Console.WriteLine($"Transaction ID: {transactionID}");
        }
    }
}
