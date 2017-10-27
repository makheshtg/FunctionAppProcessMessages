#load "../SharedMessageLogic/CreateMessageRequest.csx"

#r "Newtonsoft.Json"

using System.Net;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req,
    TraceWriter log, IAsyncCollector<CreateMessageRequest> outputQueue)
{
    var content = await req.Content.ReadAsStringAsync();

    var messageRequest = JsonConvert.DeserializeObject<CreateMessageRequest>(content);

    await outputQueue.AddAsync(messageRequest);

    log.Info($"Added {messageRequest} to queue");

    return req.CreateResponse(HttpStatusCode.OK, $"Request:  {messageRequest} added to queue");
}