var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint raiz (/) – retorna uma mensagem simples
app.MapGet("/", () => "🚀 Aplicação .NET rodando com sucesso em container Docker!");

// Endpoint de exemplo com parâmetro
app.MapGet("/api/hello/{nome}", (string nome) =>
{
    return $"Olá, {nome}! Seja bem-vindo à aplicação .NET no Docker!";
});

app.Run();
