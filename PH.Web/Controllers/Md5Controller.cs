using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Md5Controller : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create an MD5 hash from your plain text.";
        protected override string MetaKeywords { get; } = "md5,hash,password,online";
        public Md5Controller(ApplicationState state) : base(new Md5HashAlgorithmAdapter(), state)
        {
        }
    }
}