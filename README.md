# Azure CORS header setter #

Simple [ScriptCS](http://scriptcs.net/) scripts to manage Azure storage account's CORS headers. 
Created in frustration as there are no readymade methods in the Azure SDK.

Many CORS headers that this script sets fixed; change setCors.csx to suit your needs. 

Methods: 

## Dump all service properties, including CORS headers ##

    scriptcs dumpServiceProperties.csx -- [storageAccount] [storageAccountKey] 

## Add CORS headers ##

    scriptcs setCors.csx -- [storageAccount] [storageAccountKey] [verbs] [origins]
    
An example 

    scriptcs setCors.csx -- myaccount mylongkey HEAD,GET http://*.foo.bar,http://*.fu.bar

## Clear all CORS headers ##

    scriptcs clearCors.csx -- [storageAccount] [storageAccountKey] 


Inspired by [Bill Wilder's blobpost](http://blog.codingoutloud.com/2014/02/21/stupid-azure-trick-6-a-cors-toggler-command-line-tool-for-windows-azure-blobs/)