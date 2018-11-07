#r "Microsoft.Azure.EventGrid"
#r "Microsoft.WindowsAzure.Storage"

using Microsoft.Azure.EventGrid.Models;
using Microsoft.WindowsAzure.Storage.Blob;

public static void Run(EventGridEvent eventGridEvent, out string outputBlob, ILogger log)
{
    log.LogInformation(eventGridEvent.Data.ToString());

    var result = "Time: \n" + DateTime.Now.ToString()+ "\nBody:\n"+eventGridEvent.Data.ToString();
    log.LogInformation(result);

    outputBlob =  result;
}
