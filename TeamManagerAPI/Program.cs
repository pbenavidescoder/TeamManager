using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using TeamManager.Application.UseCases.Players;
using TeamManager.Domain.Interfaces;
using TeamManagerAPI.Endpoints;
using TeamManagerAPI.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<DbConnectionFactory>(_ =>
        new DbConnectionFactory(
            builder.Configuration.GetConnectionString("SqliteConnection")!,
            () => new SqliteConnection(builder.Configuration.GetConnectionString("SqliteConnection")!)
        ));
}
else
{
    builder.Services.AddScoped<DbConnectionFactory>(_ =>
        new DbConnectionFactory(
            builder.Configuration.GetConnectionString("AzureSqlConnection")!,
            () => new SqlConnection(builder.Configuration.GetConnectionString("AzureSqlConnection")!)
        ));
}

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<GetPlayersUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1");
    });
}

app.UseHttpsRedirection();

app.MapPlayerEndpoints();
//app.MapAttendanceEndpoints();


app.Run();

