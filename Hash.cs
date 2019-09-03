using System.IO;
using System.Security.Cryptography;

namespace sqlite_archive_cs
{
    public class Hash
    {

        public string GetHashSha256(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                using (SHA256 Sha256 = SHA256.Create())
                {
                    string output = Sha256.ComputeHash(stream).ToString();
                    return output;
                }
            }
        }

        public string GetHashSha512(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                using (SHA512 Sha512 = SHA512.Create())
                {
                    string output = Sha512.ComputeHash(stream).ToString();
                    return output;
                }
            }
        }
    }
}
