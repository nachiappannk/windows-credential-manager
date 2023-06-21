// See https://aka.ms/new-console-template for more information
using AdysTech.CredentialManager;
using System.Net;

Console.WriteLine("Hello, World!");
var cred = new NetworkCredential("userid", "Password");
CredentialManager.SaveCredentials("testnachicreds", cred);

var credRetrieved = CredentialManager.GetCredentials("testnachicreds");
Console.WriteLine(credRetrieved.UserName);
Console.WriteLine(credRetrieved.Password);

