using System;
using System.Security.Cryptography;
using System.Text;

namespace PH.Web.HashAdapters
{
    public class Sha512AlgorithmAdapter : HashAlgorithmAdapter
    {
        public override string Name => "SHA512";

        public override string ComputeHash(string plainText)
        {
            var alg = new SHA512CryptoServiceProvider();
            var hash = alg.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            return $"{Convert.ToBase64String(hash)}";
        }
    }
}