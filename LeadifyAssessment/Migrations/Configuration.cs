namespace LeadifyAssessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using DataLayer.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<LeadifyAssessmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LeadifyAssessmentContext context)
        {
            try
            {
                context.ContactModels.AddOrUpdate(
                  p => p.Email,
                  new ContactModel { FirstName = "Paul", LastName = "Atreides", CellPhone = "0825241234", Email = "Paul@Atreides.com" },
                  new ContactModel { FirstName = "Duncan", LastName = "Idaho", CellPhone = "0825241234", Email = "Duncan@Idaho.com" },
                  new ContactModel { FirstName = "Piter", LastName = "De Vries", CellPhone = "0825241234", Email = "Piter@DeVries.com" }
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
