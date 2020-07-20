# Introduction 

TODO

# Getting Started

TODO

# Build and Test

## Generate Api Clients from Swagger

Sample:

```
java -jar swagger-codegen-cli.jar generate -i http://cms.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dapis -DsupportingFiles -DmodelTests=false -o ../../src/Voicify.Sdk.Cms/Voicify.Sdk.Cms/Generated
```


## Generate Tests from Swagger


```
java -jar swagger-codegen-cli.jar generate -i http://cms.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -DapiTests=true -o ../../src/Voicify.Sdk.Cms/Voicify.Sdk.Cms.Tests/Generated
```

Delete any duplicated stuff that is created in the test project

Then find and replace the expected models namespace everywhere.

Find: using Voicify.Sdk.Cms.Model;
Replace with: using Voicify.Sdk.Core.Models.Model;

Then do any other replacements or fixes required in order to fix the build

Also be wary of generated tests overriding any that are explicitly setup. You may need to pull the accepted tests that are enabled out of the `Generated` folder.