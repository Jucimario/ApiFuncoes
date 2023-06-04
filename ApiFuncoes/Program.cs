using ApiFuncoes.Services.V1;
using ApiFuncoes.Services.V1.Interfaces;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Add services to the container

builder.Services.AddControllers();

//Injeção de Dependencia
builder.Services.AddScoped<INumeroExtencoService, NumeroExtencoService>();
builder.Services.AddScoped<ISomaArrayService, SomaArrayService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Informações Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "REST API FUNCOES",
            Version = "v1",
            Description = "Efetua funções especificas definidas",
            Contact = new OpenApiContact
            {
                Name = "Jucimario",
                Url = new Uri("https://github.com/jucimario")
            }
        });
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
#region Configure the HTTP request pipeline 
    
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion