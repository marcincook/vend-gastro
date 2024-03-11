using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendGastro
{
    public class TelevendLogger
    {
        private const string LogFilePath = "Televend_Log.txt";

        public static void LogPricingGroup(int availableCredit, ulong cardID)
        {
            try
            {
                // Tworzenie lub otwieranie pliku dziennika
                using (StreamWriter sw = File.AppendText(LogFilePath))
                {
                    // Pobieranie aktualnej daty i godziny
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // Zapisywanie parametrów do pliku
                    sw.WriteLine($"{timestamp} - TelevendGetPricingGroup - AvailableCredit: {availableCredit}, CardID: {cardID}");
                }
            }
            catch (Exception ex)
            {
                // Obsługa błędów przy zapisie do pliku
                Console.WriteLine($"Błąd przy zapisie do pliku dziennika: {ex.Message}");
            }
        }
    }
}
