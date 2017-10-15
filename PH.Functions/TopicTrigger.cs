using Microsoft.Azure.WebJobs.Host;
using PH.Contract.Internal;

namespace PH.Functions
{
    public class TopicTrigger
    {
        public static void Run(PasswordHashed @event, TraceWriter log)
        {
            log.Info($"ServiceBus topic trigger function processed message: {@event}");
        }
    }
}
