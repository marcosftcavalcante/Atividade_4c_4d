using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<ExoContext, ExoContext>();
        builder.Services.AddControllers();
        builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();

        var app = builder.Build();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.Run();
    }
}