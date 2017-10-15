using System;
using System.Security.Cryptography;
using System.Text;

namespace PH.Web.HashAdapters
{
    public class Sha256AlgorithmAdapter : HashAlgorithmAdapter
    {
        public override string Name => "SHA256";

        public override string ComputeHash(string plainText)
        {
            var alg = new SHA256CryptoServiceProvider();
            var hash = alg.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            return $"{Convert.ToBase64String(hash)}";
        }
    }
}