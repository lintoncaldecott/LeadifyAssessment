namespace LeadifyAssessment.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LeadifyAssessment.DataLayer.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<LeadifyAssessmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LeadifyAssessmentContext context)
        {
            context.ContactModels.AddOrUpdate(
              p => p.Email, 
              new ContactModel { FirstName = "Paul", LastName= "Atreides", CellPhone=274589654, Email= "Paul@Atreides.com" },
              new ContactModel { FirstName = "Duncan", LastName = "Idaho", CellPhone = 274589655, Email = "Duncan@Idaho.com" },
              new ContactModel { FirstName = "Piter", LastName = "De Vries", CellPhone = 274589656, Email = "Piter@DeVries.com" }
            );

        }
    }
}
