using System.Collections.Generic;

namespace PH.Web.Models
{
    public class HashResult
    {
        public string PlainText { get; set; }
        public string Hash { get; set; }
        public string AlgorithmName { get; set; }
        public IList<string> RecentRequests { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
    }
}