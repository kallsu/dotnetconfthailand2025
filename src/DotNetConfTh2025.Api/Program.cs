using DotNetConfTh2025.Api.Endpoints;
using DotNetConfTh2025.Api.Helpers;
using DotNetConfTh2025.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// #GGO-CASE : Specify the new openAPI support
//
// https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-10.0?view=aspnetcore-10.0#openapi
//
builder.Services.AddOpenApi(options =>
{
    options.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_1;
});

// Add the dependency injection for the project

// Go Baby Go !!!!!
builder.Services.AddScoped<IProductReadService, ProductReadService>();
builder.Services.AddScoped<IProductWriteService, ProductWriteService>();

//
// #GGO-CASE : Add Validation as default
//
builder.Services.AddValidation();

//-------------------------------------------------------
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// add endpoint -> I did not create an extension in order to avoid to mix the concepts.
// Using the old style this makes clearer the code and deliver better the contents.
GetProduct.MapGetProduct(app);
SaveProduct.MapSaveProduct(app);

Console.WriteLine("Hello World!"); // Thanks to the volunteers

app.Run();


string? mystr;

MyStringHelperBeforeDotNet10.IsNullOrEmpty(mystr);
mystr.IsNullOrEmpty();