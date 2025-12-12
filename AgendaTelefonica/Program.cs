using AgendaTelefonica.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var build = WebApplication.CreateBuilder();

            build.Services.AddControllers();
            build.Services.AddDbContext<MyDbContext>();

            var app = build.Build();

            app.MapControllers();
            app.Run();



        }
    }
}
