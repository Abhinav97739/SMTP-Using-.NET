### How to configure the SMTP without service prinicpal using .net code

1. Create an azure communication service 
2. Click on domains then add a new domaiN. The domain used here is by default of azure domain

3. After that create an email communication service
4. Got to provision doamins
5. Click on add domain
5. Select azure domain in that and then select rg, domain etc.

6. After the connection is successful copy the sender email address and connection from email commmunication service and azure communication service respectively 

7. Go the .net code 
```.net
using Azure;
using Azure.Communication.Email;
using System.Net.Http;

Console.WriteLine("Hello, World!");

string connectionString = "string input;"
EmailClient emailClient = new EmailClient(connectionString);

var subject = "Test Email";
var body = "This is a test email.";
var sender = "sender-email address";
var recipient = "reciever address";

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
```

9. After that run the .net code 