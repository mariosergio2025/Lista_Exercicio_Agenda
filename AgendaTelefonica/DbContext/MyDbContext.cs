


namespace AgendaTelefonica.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.IO;
    public class MyDbContext:DbContext
    {
        public DbSet<AgendaItem> Todos => Set<AgendaItem>(); // apontando => para um Set Agenda

        // Lembrar de fazer 1 vez o Add-Migration InitialMigration no powershell para iniciar o banco de dados

        // depois de criado a Migrations - database update no shell
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // diretorio onde o windows deixa os aplicativos salvar dados - consever ver em %appdata%
            // mas o C# tem um forma de ver comando abaixo
            // o caminho Path.Combine - combina dois Path = precisa do System.IO

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "agenda.db");

            optionsBuilder.UseSqlite($"Data Source={path}"); //string Conexoes: texto que contem os
                                                             //detalhes da para se conectar no banco (ip/host, usuario, senha,etc)
                                                             //Ver no site https://www.connectionstrings.com/
            base.OnConfiguring(optionsBuilder);

        }
    }    
}

