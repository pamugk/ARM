using System;
using System.Security.Cryptography;
using System.Text;

namespace ARM.Security
{
	public class PasswordSecurity 
	{
		public static string GenerateHash(string password, string salt)
		{
			return Convert.ToBase64String(SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(password + salt)));
		}

		public static string GenerateSalt()
		{
			var p = new RNGCryptoServiceProvider();
			var salt = new byte[64];
			p.GetBytes(salt);
			return Convert.ToBase64String(salt);
		}

        public static bool IsGoodPassword()
        {
            return true;
        }
	}
}