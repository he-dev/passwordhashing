using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha384Controller : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create an SHA384 hash from your plain text.";
        protected override string MetaKeywords { get; } = "sha384,hash,password,online";
        public Sha384Controller(ApplicationState state) : base(new Sha384AlgorithmAdapter(), state)
        {
        }
    }
}