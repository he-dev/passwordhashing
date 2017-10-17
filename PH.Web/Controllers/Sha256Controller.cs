using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha256Controller : HashControllerBase
    {
        public Sha256Controller(ApplicationState state) : base(new Sha256AlgorithmAdapter(), state)
        {
        }
    }
}