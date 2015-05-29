#load Auth.csx
// Sets CORS headers for given Azure storage account
// Usage: scriptcs cors.csx -- storageAccountName storageAccountKey

var origins =  Env.ScriptArgs[2].Split(',');

Console.Write("Changing CORS headers for " + storageAccountName); 

var blobServiceProperties = cloudBlobClient.GetServiceProperties();

// http://msdn.microsoft.com/en-us/library/windowsazure/dn535601.aspx
var corsGetAnyOriginRule = new CorsRule();
 
foreach(var origin in origins) {
	corsGetAnyOriginRule.AllowedOrigins.Add(origin); 
}
 
// Specify allowed methods 
// https://msdn.microsoft.com/en-us/library/microsoft.windowsazure.storage.shared.protocol.corshttpmethods%28v=azure.10%29.aspx
corsGetAnyOriginRule.AllowedMethods = CorsHttpMethods.Head | CorsHttpMethods.Get; 
corsGetAnyOriginRule.ExposedHeaders.Add("*"); 
corsGetAnyOriginRule.AllowedHeaders.Add("*"); 
corsGetAnyOriginRule.MaxAgeInSeconds = (int)TimeSpan.FromHours(10).TotalSeconds;
 
// Add the newly created cors rules to the list and save
blobServiceProperties.Cors.CorsRules.Add(corsGetAnyOriginRule);
cloudBlobClient.SetServiceProperties(blobServiceProperties);