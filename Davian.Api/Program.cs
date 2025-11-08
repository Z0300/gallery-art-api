using Davian.Api;
using Davian.Api.Endpoints;
using Davian.Api.Utilities;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("DEFAULT_CONNECTION");


builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddEndpoints();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();   
    app.ApplyMigrations();
    app.MapScalarApiReference(o =>
    {
        o.Title = "Marvin's Art Gallery API";
        o.Theme = ScalarTheme.Moon;
        o.DefaultHttpClient =
            new KeyValuePair<ScalarTarget, ScalarClient>(ScalarTarget.CSharp, ScalarClient.HttpClient);
    });
}

app.MapEndpoints();

app.Run();
