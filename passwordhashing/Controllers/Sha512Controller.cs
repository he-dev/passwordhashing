using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Sha512Controller : HashControllerBase
    {
        public Sha512Controller() : base(new Sha512AlgorithmAdapter())
        {
        }
    }
}