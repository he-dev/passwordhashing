using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class BCryptController : HashControllerBase
    {
        public BCryptController() : base((HashAlgorithmAdapter) new BCryptAlgorithmAdapter())
        {
        }
    }
}