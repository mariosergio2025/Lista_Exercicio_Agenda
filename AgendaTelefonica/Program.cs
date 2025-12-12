using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var build = WebApplication.CreateBuilder();

            build.Services.AddControllers();

            var app = build.Build();

            app.MapControllers();
            app.Run();



        }
    }
}
