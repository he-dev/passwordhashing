using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class Md5Controller : HashControllerBase
    {
        public Md5Controller(ApplicationState state) : base(new Md5HashAlgorithmAdapter(), state)
        {
        }
    }
}