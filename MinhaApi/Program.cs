var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Home", () =>
{
    return Results.Ok("Bem vindo!");
});

app.MapGet("/Contato", () =>
{
    return Results.Ok("Tel: (00) 0000-0000");
});

app.MapGet("/{nome}", (string nome) =>
{
    return Results.Ok($"Bem vindo! {nome}");
});


app.MapPost("", (User user) =>
{
    return Results.Ok(user);
});
app.Run();

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
}
