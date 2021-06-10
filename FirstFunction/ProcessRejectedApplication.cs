using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FirstFunction
{
    public static class ProcessRejectedApplication
    {
        [FunctionName("ProcessRejectedApplication")]
        public static void Run([BlobTrigger("rejected-application/{name}", Connection = "")]string ccApplicationJson, string name, ILogger log)
        {
            CCApplication ccApplication = JsonConvert.DeserializeObject<CCApplication>(ccApplicationJson);
            log.LogInformation($"Process Rejected CCApplication Blob Trigger for \n Name:{ccApplication.Name}");
        }
    }
}
