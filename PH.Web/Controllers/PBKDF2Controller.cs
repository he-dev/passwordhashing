using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class PBKDF2Controller : HashControllerBase
    {
        public PBKDF2Controller() : base((HashAlgorithmAdapter) new Pbkdf2AlgorithmAdapter())
        {
            
        }
    }
}