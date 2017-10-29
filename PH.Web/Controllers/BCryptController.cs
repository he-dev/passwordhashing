using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class BCryptController : HashControllerBase
    {
        protected override string MetaDescription { get; } = "A free tool to create a BCrypt hash from your plain text.";
        protected override string MetaKeywords { get; } = "bcrypt,hash,password,online";

        public BCryptController(ApplicationState state) : base(new BCryptAlgorithmAdapter(), state)
        {
        }
    }
}