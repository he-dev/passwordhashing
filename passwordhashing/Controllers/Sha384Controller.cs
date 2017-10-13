using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha384Controller : HashControllerBase
    {
        public Sha384Controller() : base(new Sha384AlgorithmAdapter())
        {
        }
    }
}