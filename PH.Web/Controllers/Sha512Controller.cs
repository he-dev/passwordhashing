using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha512Controller : HashControllerBase
    {
        public Sha512Controller(ApplicationState state) : base(new Sha512AlgorithmAdapter(), state)
        {
        }
    }
}