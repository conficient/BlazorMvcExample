# BlazorMvcExample
Experiment to see how to make MVC and Blazor co-exist

If you create a new Blazor WASM (client-side) application with authentication enabled, a request to any MVC controller with
the `[Authorize]` attribute returns a 401 not-authorized response. Expected a redirect to the login page.

## To test

 - Run the application and click the public link: /Mvc/Public - should get a basic response showing the content.
 - click the private link: /Mvc/Private - get a 401 browser error page.
 
## References: 

 - https://github.com/dotnet/aspnetcore/issues/13709
 - https://github.com/dotnet/aspnetcore/issues/19148
 - https://github.com/dotnet/aspnetcore/issues/14916
 - https://github.com/enkodellc/blazorboilerplate
 - https://github.com/stavroskasidis/BlazorWithIdentity -
