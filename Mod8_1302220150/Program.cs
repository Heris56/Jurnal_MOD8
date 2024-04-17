// See https://aka.ms/new-console-template for more information

using System.Text.Json;

class Program()
{
    static void Main(string[] args)
    {
        int biayaTF, tf;
        Console.WriteLine("test");
        BankConfig bank = new BankConfig();

        var config = JsonSerializer.Deserialize<BankConfig>(bank.JSON);
        config.ubahlang("id");
        if (config.config1 == "id")
        {
            Console.Write("Masukan jumlah uang yang akan ditransfer: ");
            String input = Console.ReadLine();
            int.TryParse(input, out tf);
            if (tf <= config.TF.config2)
            {
                biayaTF = config.TF.config3;
            }
            else
            {
                biayaTF = config.TF.config4;
            }
            Console.WriteLine("biaya transaksi: " + biayaTF);
            Console.WriteLine("Total biaya: " + (tf + biayaTF));

            Console.WriteLine("pilih metode transfer: ");
            Console.WriteLine("1. RTO('real time')");
            Console.WriteLine("2. SKN");
            Console.WriteLine("3. RTGS");
            Console.WriteLine("4. BI FAST");
            Console.WriteLine("Pilihan anda: ");
            input = Console.ReadLine();
            Console.WriteLine("konfirmasi dengan mengetikan " + config.confirm.config7);
            String confirm = Console.ReadLine();
            if (confirm == config.confirm.config7)
            {
                Console.WriteLine("Transfer Berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }
        else if (config.config1 == "en")
        {
            Console.Write("Please insert the ammount of money to transfer: ");
            String input = Console.ReadLine();
            int.TryParse(input, out tf);
            if (tf <= config.TF.config2)
            {
                biayaTF = config.TF.config3;
            }
            else
            {
                biayaTF = config.TF.config4;
            }
            Console.WriteLine("fee: " + biayaTF);
            Console.WriteLine("Total ammount: " + (tf + biayaTF));

            Console.WriteLine("select Transfer methods: ");

            Console.WriteLine("1. RTO('real time')");
            Console.WriteLine("2. SKN");
            Console.WriteLine("3. RTGS");
            Console.WriteLine("4. BI FAST");
            Console.WriteLine("Your choice: ");
            input = Console.ReadLine();
            Console.WriteLine("please confirm by typing " + config.confirm.config6);
            String confirm = Console.ReadLine();
            if (confirm == config.confirm.config6)
            {
                Console.WriteLine("Transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is canceled");
            }
        }
        
    }
}
