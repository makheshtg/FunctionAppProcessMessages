#load "../SharedMessageLogic/CreateMessageRequest.csx"

using System;

public static void Run(CreateMessageRequest input, TraceWriter log, out CreateMessageRequest outputQueue)
{
    log.Info($"C# manually triggered function called with input: {input}");
    outputQueue = input;
}