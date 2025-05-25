using Microsoft.AspNetCore.OpenApi;

namespace Azure.AspNet.Web.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddOpenApi("weatherforecast");
            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.MapOpenApi();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
