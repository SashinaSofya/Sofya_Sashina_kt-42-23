using NLog;
using NLog.Web;
using Microsoft.EntityFrameworkCore;
using Sofya_Sashina_kt_42_23.Database;


var builder = WebApplication.CreateBuilder(args);

var logger = LogManager
    .Setup()
    .LoadConfigurationFromAppSettings()
    .GetCurrentClassLogger();

try
{
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("StudentDbContext")));

    // Add services to the container.
    builder.Services.AddControllers();

    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();

        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/openapi/v1.json", "v1");
        });
    }

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Stopped program because of exception");
    throw;
}
finally
{
    LogManager.Shutdown();
}