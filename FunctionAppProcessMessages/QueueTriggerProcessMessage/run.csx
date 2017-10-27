#load "../SharedMessageLogic/CreateMessageRequest.csx"
#load "../SharedMessageLogic/MessageToSent.csx"

#r "Newtonsoft.Json"

using System;
using Newtonsoft.Json;

public static void Run(CreateMessageRequest messageRequest, TraceWriter log, out string greetingRequest)
{
    log.Info($"C# Queue trigger function processed: {messageRequest}");
    
    var greetingMessage = new MessageToSent
    {
        Number = messageRequest.Number,
        Message = $"Hello {messageRequest.FirstName}"
    };

    greetingRequest = JsonConvert.SerializeObject(greetingMessage);
}