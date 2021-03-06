# AspNetNullRefValidation
Sanbox for reproducing the issue with the nullable ref validation for GET params

### Expected
Both `/test/base` and `/test/own` are expected to return 400 for missing string query paramter.

### Actual
`/test/base` reutns 200
![image](https://user-images.githubusercontent.com/6978458/144517082-dd757220-a453-49e6-8766-4f421db033cd.png)

### Details
I think the reason starts here:    
https://github.com/dotnet/aspnetcore/blob/a450cb69b5e4549f5515cdb057a68771f56cefd7/src/Mvc/Mvc.DataAnnotations/src/DataAnnotationsMetadataProvider.cs#L352
and finally here:    
https://github.com/dotnet/aspnetcore/blob/a450cb69b5e4549f5515cdb057a68771f56cefd7/src/Mvc/Mvc.DataAnnotations/src/DataAnnotationsMetadataProvider.cs#L507

So `NullableContextAttribute` is not set on either controller (class) or action (method).
Playing with adding private/public reference type fields to the `TestController` class helps to resolve the issue.

![image](https://user-images.githubusercontent.com/6978458/144517507-fb909c55-29d0-4f1f-a2a3-6eb9e2ff7e62.png)
![image](https://user-images.githubusercontent.com/6978458/144517517-3be18adf-b395-455c-9749-dc2ebe97ef0f.png)




