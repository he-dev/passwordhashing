using System;
using System.Security.Cryptography;
using System.Text;

namespace PH.Web.HashAdapters
{
    public class Md5HashAlgorithmAdapter : HashAlgorithmAdapter
    {
        public override string Name => "MD5";

        public override string ComputeHash(string plainText)
        {
            var alg = new MD5CryptoServiceProvider();
            var hash = alg.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            return $"{Convert.ToBase64String(hash)}";
        }
    }
}