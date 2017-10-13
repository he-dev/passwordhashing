using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha256Controller : HashControllerBase
    {
        public Sha256Controller() : base(new Sha256AlgorithmAdapter())
        {
        }
    }
}