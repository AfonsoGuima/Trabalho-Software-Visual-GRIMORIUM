var builder = WebApplication.CreateBuilder(args);

// OBRIGATÓRIO: Registra o suporte aos Controllers no C#
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("LiberarTudo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("LiberarTudo");

app.UseAuthorization();

// OBRIGATÓRIO: Mapeia e publica as rotas dos seus Controllers no servidor
app.MapControllers();

app.Run();