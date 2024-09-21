﻿using raylinder.API.Domains;

var environmentWebsiteUrl = "";

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;

if (env != null)
{
    builder.Configuration.SetBasePath(env.ContentRootPath).AddEnvironmentVariables();

    switch (env.EnvironmentName)
    {
        case "Local":
        case "Development":
            environmentWebsiteUrl = "http://localhost:5275";
            break;
        case "Production":
            environmentWebsiteUrl = "http://www.raylinder.com";
            break;
    }

    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(policy =>
            policy.WithOrigins(environmentWebsiteUrl).AllowAnyHeader().AllowAnyMethod().AllowCredentials()
        );
    });
}

builder.Services.AddLogging(loggingBuilder =>
{
    // Add logging services.
    loggingBuilder.ClearProviders();
    loggingBuilder.AddConfiguration(builder.Configuration.GetSection("Logging"));

    if (env.EnvironmentName == "Local" || env.EnvironmentName == "Development")
    {
        loggingBuilder.AddConsole();
        loggingBuilder.AddDebug();
    }
});

builder.Services.AddScoped<IFeaturedWorkManager, FeaturedWorkManager>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseStaticFiles();
app.UseRouting();

app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
