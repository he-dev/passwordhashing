using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha256Controller : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create an SHA256 hash from your plain text.";
        protected override string MetaKeywords { get; } = "sha256,hash,password,online";
        public Sha256Controller(ApplicationState state) : base(new Sha256AlgorithmAdapter(), state)
        {
        }
    }
}