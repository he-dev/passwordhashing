using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha1Controller : HashControllerBase
    {
        public Sha1Controller(ApplicationState state) : base(new Sha1AlgorithmAdapter(), state)
        {
        }
    }
}