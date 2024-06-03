using OnlineStore.BLL.Services.Interfaces;
using System.Security.Cryptography;

namespace OnlineStore.BLL.Services.Classes
{
    public class HashService : IHashService
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int Iterations = 10000;

        public string HashPassword(string password)
        {
            byte[] salt = new byte[SaltSize];
            new RNGCryptoServiceProvider().GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        public bool VerifyPassword(string enteredPassword, string savedPasswordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            byte[] hash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, hash, 0, HashSize);

            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt ?? default!, Iterations);
            byte[] hashToVerify = pbkdf2.GetBytes(HashSize);

            for (int step = 0; step < HashSize; step++)
            {
                if (hashBytes[step + SaltSize] != hashToVerify[step])
                    return false;
            }

            return true;
        }
    }
}