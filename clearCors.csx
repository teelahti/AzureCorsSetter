#load Auth.csx
// Clears all CORS headers from a given Azure storage account
// Usage: scriptcs clearCors.csx -- storageAccountName storageAccountKey

Console.WriteLine("Clearing CORS headers for " + storageAccountName); 

var blobServiceProperties = cloudBlobClient.GetServiceProperties();
blobServiceProperties.Cors.CorsRules.Clear();
cloudBlobClient.SetServiceProperties(blobServiceProperties);

Console.WriteLine("...done.");
 