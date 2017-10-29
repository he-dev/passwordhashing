using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class PBKDF2Controller : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create a PBKDF2 hash from your plain text.";
        protected override string MetaKeywords { get; } = "pbkdf2,hash,password,online";
        public PBKDF2Controller(ApplicationState state) : base(new Pbkdf2AlgorithmAdapter(), state)
        {
            
        }
    }
}