using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha1Controller : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create an SHA1 hash from your plain text.";
        protected override string MetaKeywords { get; } = "sha1,hash,password,online";
        public Sha1Controller(ApplicationState state) : base(new Sha1AlgorithmAdapter(), state)
        {
        }
    }
}