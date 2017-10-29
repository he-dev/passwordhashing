using Microsoft.AspNetCore.Mvc;
using PH.Web.HashAdapters;
using PH.Web.Models;

namespace PH.Web.Controllers
{
    public abstract class HashControllerBase: Controller
    {
        private readonly HashAlgorithmAdapter _hashAlgorithm;
        private readonly ApplicationState _applicationState;

        protected virtual string MetaKeywords { get; } = string.Empty;

        protected virtual string MetaDescription { get; } = string.Empty;

        protected HashControllerBase(HashAlgorithmAdapter hashAlgorithm, ApplicationState applicationState)
        {
            _hashAlgorithm = hashAlgorithm;
            _applicationState = applicationState;
        }

        [ResponseCache(Duration = 60)]
        public IActionResult Index(string plainText)
        {
            var result = new HashResult
            {
                PlainText = plainText,
                AlgorithmName = _hashAlgorithm.Name,
                RecentRequests = _applicationState.GetRecentHashes(_hashAlgorithm.Name),
                MetaDescription = MetaDescription,
                MetaKeywords = MetaKeywords
            };

            if (!string.IsNullOrEmpty(plainText))
            {
                _applicationState.AddPlainText(_hashAlgorithm.Name, plainText);
                result.Hash = _hashAlgorithm.ComputeHash(plainText);
            }

            return View("~/Views/Hash/Index.cshtml", result);
        }
    }
}