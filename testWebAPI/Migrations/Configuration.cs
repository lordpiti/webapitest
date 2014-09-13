namespace testWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using testWebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<testWebAPI.Models.testWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(testWebAPI.Models.testWebAPIContext context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
                   new Contact
                   {
                       Name = "Pablo Amil",
                       Address = "1234 Main St",
                       City = "A Corunha",
                       State = "Galicia",
                       Zip = "10999",
                       Email = "debra@example.com",
                       Twitter = "debra_example",
                       Department = "Deportivo de A Corunha",
                       FirstName = "Pablo", 
                       LastName = "Amil", 
                       ManagerId = 0, 
                       Title = "Puto amo", 
                       Reports = 4,
                       Blog = "http://marca.feedsportal.com/rss/futbol_equipos_deportivo.xml"
                   },
                   new Contact
                   {
                       Name = "Jose Lairado",
                       Address = "1234 Main St",
                       City = "Badalona",
                       State = "Catalunya",
                       Zip = "10999",
                       Email = "debra@example.com",
                       Twitter = "debra_example",
                       Department = "Atletico de Madrid",
                       FirstName = "Jose", 
                       LastName = "Lairao", 
                       ManagerId = 1, 
                       Title = "Borracho", 
                       Reports = 0,
                       Blog = "http://marca.feedsportal.com/rss/futbol_equipos_atletico.xml"
                   },
                   new Contact
                   {
                       Name = "Albert Perez",
                       Address = "1234 Main St",
                       City = "Badalona",
                       State = "Catalunya",
                       Zip = "10999",
                       Email = "debra@example.com",
                       Twitter = "debra_example",
                       Department = "F.C Barcelona",
                       FirstName = "Albert", 
                       LastName = "Perez", 
                       ManagerId = 1, 
                       Title = "Pillador", 
                       Reports = 0,
                       Blog = "http://marca.feedsportal.com/rss/futbol_equipos_barcelona.xml"
                   },
                   new Contact
                   {
                       Name = "Jaime Garcia",
                       Address = "1234 Main St",
                       City = "Valencia",
                       State = "Comunidad Valenciana",
                       Zip = "10999",
                       Email = "debra@example.com",
                       Twitter = "debra_example",
                       Department = "Hercules",
                       FirstName = "Jaime", 
                       LastName = "Garcia", 
                       ManagerId = 1, 
                       Title = "Diablo",
                       Reports = 0,
                       Blog = "http://marca.feedsportal.com/rss/futbol_equipos_valencia.xml"
                   },
                   new Contact
                   {
                       Name = "David Olivares",
                       Address = "1234 Main St",
                       City = "Barakaldo",
                       State = "Euskadi",
                       Zip = "10999",
                       Email = "debra@example.com",
                       Twitter = "debra_example",
                       Department = "Real Madrid",
                       FirstName = "David", 
                       LastName = "Olivares", 
                       ManagerId = 1, 
                       Title = "Seguidor",
                       Reports = 0,
                       Blog = "http://marca.feedsportal.com/rss/futbol_equipos_real_madrid.xml"
                   },
                    new Contact
                    {
                        Name = "LUIS ALBERTO ADRAN",
                        Address = "1234 Main St",
                        City = "London",
                        State = "Shepherds Bush",
                        Zip = "10999",
                        Email = "debra@example.com",
                        Twitter = "debra_example",
                        Department = "Real Madrid",
                        FirstName = "Luis Alberto",
                        LastName = "Adran",
                        ManagerId = 1,
                        Title = "ESHHHHKIUSMI",
                        Reports = 0,
                        Blog = "http://marca.feedsportal.com/rss/futbol_equipos_real_madrid.xml"
                    }
            );
        }
        
    }
}
