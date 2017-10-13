using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace PH.Web.HashAdapters
{
    public class Pbkdf2AlgorithmAdapter : HashAlgorithmAdapter
    {
        private static readonly RandomNumberGenerator Random = RandomNumberGenerator.Create();
        public override string Name => "PBKDF2";

        public override string ComputeHash(string plainText)
        {
            var salt = new byte[16];
            Random.GetBytes(salt);

            var bytes = KeyDerivation.Pbkdf2(plainText, salt, KeyDerivationPrf.HMACSHA512, 100, 16);
            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(bytes)}";
        }
    }
}