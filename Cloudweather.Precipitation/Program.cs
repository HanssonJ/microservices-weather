using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

app.MapGet("/observation/{zip}", (string zip, [FromQuery] int? days) => {
    return Results.Ok(zip);
});

app.Run();
