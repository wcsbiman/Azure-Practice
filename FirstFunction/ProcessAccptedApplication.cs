using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FirstFunction
{
    public static class ProcessAccptedApplication
    {
        [FunctionName("ProcessAccptedApplication")]
        public static void Run([BlobTrigger("accepted-application/{name}", Connection = "")]string ccApplicationJson, string name, ILogger log)
        {
            CCApplication ccApplication = JsonConvert.DeserializeObject<CCApplication>(ccApplicationJson);
            log.LogInformation($"Process Accpted Application Blob Trigger for \n Name:{ccApplication.Name}");
        }
    }
}
