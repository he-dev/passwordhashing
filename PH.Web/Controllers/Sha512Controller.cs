using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha512Controller : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create an SHA512 hash from your plain text.";
        protected override string MetaKeywords { get; } = "sha512,hash,password,online";
        public Sha512Controller(ApplicationState state) : base(new Sha512AlgorithmAdapter(), state)
        {
        }
    }
}