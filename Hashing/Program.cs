using System;
using System.Text;

namespace Hashing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isRunning = true;
            Hash hash = new Hash();

            while (isRunning)
            {

                Console.WriteLine("Time for some hashing\r\n");

                Console.WriteLine("choose your computer & Validator");

                Console.WriteLine("Press 1 for SHA1");
                Console.WriteLine("Press 2 for SHA256");
                Console.WriteLine("Press 3 for SHA384");
                Console.WriteLine("Press 4 for SHA512");
                Console.WriteLine("Press 5 for HMACSHA1");
                Console.WriteLine("Press 6 for HMACSHA256");
                Console.WriteLine("Press 7 for HMACSHA384");
                Console.WriteLine("Press 8 for HMACSHA512");
                Console.WriteLine("Press 0 for EXIT\r\n");

                Console.Write("SELECT: ");

                string userinput = Console.ReadLine();
                
                if (userinput == "0")
                {
                    isRunning = false;

                }

                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("SHA1\r\n");
                        Console.Write("Input message: ");
                        string message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha1(message))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("SHA256\r\n");
                        Console.Write("Input message: ");
                        message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha256(message))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("SHA384\r\n");
                        Console.Write("Input message: ");
                        message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha384(message))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("SHA512\r\n");
                        Console.Write("Input message: ");
                        message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha512(message))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    case "5":

                        Hmac hmac = new Hmac(Hmactypes.HMACSHA1);

                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        string key = Console.ReadLine();
                        byte[] macBytes = hmac.HmacAlgorithm(message, key);
                        Console.WriteLine($"\r\nMAC ASCII: {Convert.ToBase64String(macBytes)}");
                        Console.WriteLine($"MAC HEX: {BitConverter.ToString(macBytes).Replace("-", string.Empty)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();

                        Console.Clear();
                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        Console.Write("Input Mac: ");
                        string hashInput = Console.ReadLine();
                        Console.WriteLine($"\r\n HMAC IS VALID: {hmac.Validate(message, key, hashInput)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;



                    case "6":
                        hmac = new Hmac(Hmactypes.SHA256);
                      
                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        macBytes = hmac.HmacAlgorithm(message ,key);
                        Console.WriteLine($"\r\nMAC ASCII: {Convert.ToBase64String(macBytes)}");
                        Console.WriteLine($"MAC HEX: {BitConverter.ToString(macBytes).Replace("-", string.Empty)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();

                        Console.Clear();
                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        Console.Write("Input Mac: ");
                        hashInput = Console.ReadLine();
                        Console.WriteLine($"\r\n HMAC IS VALID: {hmac.Validate(message,key, hashInput)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    case "7":
                        hmac = new Hmac(Hmactypes.SHA384);

                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        macBytes = hmac.HmacAlgorithm(message, key);
                        Console.WriteLine($"\r\nMAC ASCII: {Convert.ToBase64String(macBytes)}");
                        Console.WriteLine($"MAC HEX: {BitConverter.ToString(macBytes).Replace("-", string.Empty)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();

                        Console.Clear();
                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        Console.Write("Input Mac: ");
                        hashInput = Console.ReadLine();
                        Console.WriteLine($"\r\n HMAC IS VALID: {hmac.Validate(message, key, hashInput)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    case "8":
                        hmac = new Hmac(Hmactypes.SHA512);

                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        macBytes = hmac.HmacAlgorithm(message, key);
                        Console.WriteLine($"\r\nMAC ASCII: {Convert.ToBase64String(macBytes)}");
                        Console.WriteLine($"MAC HEX: {BitConverter.ToString(macBytes).Replace("-", string.Empty)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();

                        Console.Clear();
                        Console.Write("Input Message: ");
                        message = Console.ReadLine();
                        Console.Write("Input Key: ");
                        key = Console.ReadLine();
                        Console.Write("Input Mac: ");
                        hashInput = Console.ReadLine();
                        Console.WriteLine($"\r\n HMAC IS VALID: {hmac.Validate(message, key, hashInput)}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
