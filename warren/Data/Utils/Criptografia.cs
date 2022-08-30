using System.Security.Cryptography;
using System.Text;

namespace Data.Utils
{
    internal class Criptografia
    {
        public static string Criptografar(string input)
        {

            MD5 md5 = MD5.Create();
            byte[] entradaBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(entradaBytes);

            //StringBuilder sb = new();
            //foreach (byte byt in hash)
            //{
            //    sb.Append(byt.ToString("X2"));
            //}
            //return sb.ToString();

            return Convert.ToBase64String(hash);

        }
    }
}
