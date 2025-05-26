using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/hello", () => $"Hello from {builder.Environment.ApplicationName}");
app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();
