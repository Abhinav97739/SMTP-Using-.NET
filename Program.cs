using Azure;
using Azure.Communication.Email;
using System.Net.Http;

Console.WriteLine("Hello, World!");

string connectionString = "endpoint=https://testcomm-service.unitedstates.communication.azure.com/;accesskey=553DRxd2Emt9NwuoVJSyk7qS4aDLDPyHBtekDoIsqAPgKTEDL7owJQQJ99BEACULyCpnbo2BAAAAAZCSWDA2";
EmailClient emailClient = new EmailClient(connectionString);

var subject = "Test Email";
var body = "This is a test email.";
var sender = "doNotReply@f0816a49-8bf4-4237-8f94-ac7b7b97c96f.azurecomm.net";
var recipient = "farazansari9993@gmail.com";

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
