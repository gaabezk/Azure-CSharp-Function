using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using function1.models;

namespace Company.Function
{
    public static class FunctionCsharp
    {
        [FunctionName("FunctionCsharp")]
        public static async Task<string> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] Pessoa pessoa,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            
            return pessoa.ToString() != null
                ? $"{pessoa.Nome} mora em {pessoa.Cidade} e tem {pessoa.Idade} anos"
                : "Passe um json com nome, cidade e idade";
        }
    }
}
