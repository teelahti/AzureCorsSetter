# Azure CORS header setter #

Simple [ScriptCS](http://scriptcs.net/) scripts to manage Azure storage account's CORS headers. 
Created in frustration as there are no readymade methods in the Azure SDK.

Many CORS headers that this script sets are hard coded; change setCors.csx to suit your needs. 

Methods: 

## Dump all service properties, including CORS headers ##

    scriptcs dumpServiceProperties.csx -- [storageAccount] [storageAccountKey] 

## Add CORS headers to the list of rules ##

Verbs are fixed in this version, change them directly in the script. 

    scriptcs addCors.csx -- [storageAccount] [storageAccountKey] [origins]
    
An example 

    scriptcs addCors.csx -- myaccount mylongkey http://app.foo.bar,http://app.fu.bar
    scriptcs addCors.csx -- myaccount mylongkey *
    
Note, that unfortunately CORS standard does not support star subdomains like http://*.foo.bar

## Clear all CORS headers ##

    scriptcs clearCors.csx -- [storageAccount] [storageAccountKey] 


## Inspecting properties returned for a blob ##
 
You can inspect CORS properties with curl:

    curl -H "Origin: http://app.foo.bar" -H "Access-Control-Request-Method: GET" -H "Access-Control-Request-Headers: X-Requested-With" -X OPTIONS --verbose http://mystorageaccount.blob.core.windows.net/mycontainer/myblob.txt 




Inspired by [Bill Wilder's blobpost](http://blog.codingoutloud.com/2014/02/21/stupid-azure-trick-6-a-cors-toggler-command-line-tool-for-windows-azure-blobs/)