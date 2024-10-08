var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Api is working";
});

app.MapGet("/hi", () =>
{
    return "Hi from /hi route";
});

app.MapPost("/", () =>
{
    return "POST is working!";
});

app.MapPatch("/", () =>
{
    return "Patch is working!";
});

app.MapDelete("/", () =>
{
    return "Delete is working!";
});


app.Run();

