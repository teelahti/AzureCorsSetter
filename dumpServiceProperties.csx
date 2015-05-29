#load Auth.csx
// Dumps all service properties - including CORS headers for a given Azure storage account.
// Usage: scriptcs dumpServiceProperties.csx -- storageAccountName storageAccountKey

Console.WriteLine("CORS headers for " + storageAccountName + ":"); 

var properties = cloudBlobClient.GetServiceProperties();
var s = Newtonsoft.Json.JsonConvert.SerializeObject(properties, Formatting.Indented);
Console.WriteLine(s);
 