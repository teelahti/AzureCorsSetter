using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Shared.Protocol;
using Newtonsoft.Json;

var storageAccountName = Env.ScriptArgs[0];
var storageAccountKey = Env.ScriptArgs[1];

var blobServiceUri = new Uri(String.Format("https://{0}.blob.core.windows.net", storageAccountName));
var storageCredentials = new StorageCredentials(storageAccountName, storageAccountKey);
var cloudBlobClient = new CloudBlobClient(blobServiceUri, storageCredentials);
