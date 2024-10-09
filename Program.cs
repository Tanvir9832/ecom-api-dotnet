var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Api is working";
});



var products = new List<Product>(){
    new Product("Samsung", 100),
    new Product("Iphone", 200),
};
app.MapGet("/hi", () =>
{
    return Results.Ok(products);
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

public record Product(string Name, decimal Price);