using AgendaTelefonica.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;


namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var build = WebApplication.CreateBuilder();

            build.Services.AddControllers();
            build.Services.AddDbContext<MyDbContext>();
            build.Services.AddSwaggerGen();

            var app = build.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();
            app.Run();



        }
    }
}
