﻿public class MessageSentLog
{
    public string Number;
    public string Message;
    public string ReceiptId;

    public override string ToString() => $"{ReceiptId} {Number} {Message}";
}