using raylinder.API.Domains;

var policyName = "CorsPolicy";
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
            //policy.WithOrigins(environmentWebsiteUrl).AllowAnyHeader().AllowAnyMethod().AllowCredentials()
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials()
        );

        //options.AddPolicy("AllowSpecificOrigin", policy =>
        //    policy.WithOrigins(environmentWebsiteUrl).AllowAnyHeader().AllowAnyMethod().AllowCredentials()
        //);
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

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// if getting "has been blocked by CORS policy: No 'Access-Control-Allow-Origin' header is present on the requested resource." error, must use these 2 BEFORE app.UseCors();
app.UseStaticFiles(); // 🔴 here it is
app.UseRouting(); // 🔴 here it is

//app.UseCors("AllowSpecificOrigin");
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
