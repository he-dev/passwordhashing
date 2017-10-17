using PH.Web.HashAdapters;

namespace PH.Web.Controllers
{
    public class PBKDF2Controller : HashControllerBase
    {
        public PBKDF2Controller(ApplicationState state) : base(new Pbkdf2AlgorithmAdapter(), state)
        {
            
        }
    }
}