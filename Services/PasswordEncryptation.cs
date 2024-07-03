using System.Security.Cryptography;
using System.Text;

namespace Farmacia.Services
{
    internal class PasswordEncryptation
    {
        public static string EncryptPasswprd(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (SHA256 sha256 = SHA256.Create())
            {
                if (password.Length > 20)
                {
                    return password;
                }
                else
                {
                    byte[] bytesTexto = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = sha256.ComputeHash(bytesTexto);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("x2"));
                    }

                    return sb.ToString();

                }

            }

        }

    }
}
