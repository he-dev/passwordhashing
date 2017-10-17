using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class BCryptController : HashControllerBase
    {
        public BCryptController(ApplicationState state) : base(new BCryptAlgorithmAdapter(), state)
        {
        }
    }
}