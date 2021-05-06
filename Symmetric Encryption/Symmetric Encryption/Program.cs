using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Symmetric_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "Pa$$w0rd";
            var salt = "S@lt";

            //Generate secret key and IV
            var rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
            //decide algorithm
            var algorithm = new AesManaged();

            var rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            var rgbIV = rgb.GetBytes(algorithm.BlockSize / 8);

            var bufferstream = new FileStream("C:\\MSSA Files\\Symmetric.txt", FileMode.OpenOrCreate);

            //encryption
            var algo = algorithm.CreateEncryptor(rgbKey, rgbIV);

            //where, which algo, write mode
            var cryptostream = new CryptoStream(bufferstream, algo, CryptoStreamMode.Write);
            byte[] transform = Encoding.Unicode.GetBytes("This is to be encrypted, what a beautiful world we live in!");
            //secret message you want to keep in the txt file
            //encryption:what
            cryptostream.Write(transform, 0, transform.Length); //start writing in file, offset 0 means starts at the beginning
            cryptostream.FlushFinalBlock(); //clearing out the buffer

            cryptostream.Close(); //close out stream
            bufferstream.Close(); //close out filestream (all file handles, so file doesn't remain locked)

            Console.WriteLine("Text encrypted");

            //symmetric decryption
            byte[] decryptedbuffer = new byte[100];
            var decalgo = algorithm.CreateDecryptor(rgbKey, rgbIV);
            var filestream = new FileStream("C:\\MSSA Files\\Symmetric.txt", FileMode.Open);

            //where, which, mode
            var cryptostreamnew = new CryptoStream(filestream, decalgo, CryptoStreamMode.Read);
            cryptostreamnew.Read(decryptedbuffer, 0, 100);

            string s = Encoding.Unicode.GetString(decryptedbuffer);
            Console.WriteLine("This is the data from file:");
            Console.WriteLine(s);

            filestream.Close();
            cryptostreamnew.Close();

            Console.ReadLine();
        }
    }
}
