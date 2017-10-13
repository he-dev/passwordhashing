using Microsoft.AspNetCore.Mvc;
using PH.Web.HashAdapters;
using PH.Web.Models;

namespace PH.Web.Controllers
{
    public abstract class HashControllerBase: Controller
    {
        private readonly HashAlgorithmAdapter _hashAlgorithm;

        protected HashControllerBase(HashAlgorithmAdapter hashAlgorithm)
        {
            _hashAlgorithm = hashAlgorithm;
        }

        public IActionResult Index(string plainText)
        {
            var result = new HashResult
            {
                PlainText = plainText,
                AlgorithmName = _hashAlgorithm.Name
            };

            if (!string.IsNullOrEmpty(plainText))
            {
                result.Hash = _hashAlgorithm.ComputeHash(plainText);
            }

            return View("~/Views/Hash/Index.cshtml", result);
        }
    }
}