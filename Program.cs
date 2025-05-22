using Azure;
using Azure.Communication.Email;
using System.Net.Http;

Console.WriteLine("Hello, World!");

string connectionString = "CONNECTION-STRING-HERE";
EmailClient emailClient = new EmailClient(connectionString);

var subject = "Test Email";
var body = "This is a test email.";
var sender = "DOMAIN-EMAIL";
var recipient = "SENDER-EMAIL";

try 
{
    EmailSendOperation emailSendOperation = await emailClient.SendAsync(Azure.WaitUntil.Completed, sender, recipient, subject, body);
    EmailSendResult status = emailSendOperation.Value;

    Console.WriteLine($"Status: {emailSendOperation.Value.Status}");
}
catch(RequestFailedException ex)
{
    Console.WriteLine($"code: {ex.ErrorCode}, message: {ex.Message}");
}
