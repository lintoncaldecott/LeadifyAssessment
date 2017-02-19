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
                  new ContactModel { FirstName = "The", LastName = "Doctor", CellPhone = "0820000001", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Ellen", LastName = "Ripley", CellPhone = "0820000002", Email = "Aliensaga@gmail.com" },
                  new ContactModel { FirstName = "Darth", LastName = "Vader", CellPhone = "0820000003", Email = "StarWarssaga@gmail.com" },
                  new ContactModel { FirstName = "Kerr", LastName = "Avon", CellPhone = "0820000004", Email = "Blakes7@gmail.com" },
                  new ContactModel { FirstName = "Malcolm", LastName = "Reynolds", CellPhone = "0820000005", Email = "FireflySerenity@gmail.com" },
                  new ContactModel { FirstName = "GKar", LastName = "GKar", CellPhone = "0820000006", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "HAL-9000", LastName = "HAL-9000", CellPhone = "0820000007", Email = "2001ASpaceOdyssey@gmail.com" },
                  new ContactModel { FirstName = "Rick", LastName = "Deckard", CellPhone = "0820000008", Email = "BladeRunner@gmail.com" },
                  new ContactModel { FirstName = "Han", LastName = "Solo", CellPhone = "0820000009", Email = "StarWarssaga@gmail.com" },
                  new ContactModel { FirstName = "Spock", LastName = "Spock", CellPhone = "0820000010", Email = "StarTreksaga@gmail.com" },
                  new ContactModel { FirstName = "John", LastName = "Crichton", CellPhone = "0820000011", Email = "Farscape@gmail.com" },
                  new ContactModel { FirstName = "Roy", LastName = "Batty", CellPhone = "0820000012", Email = "BladeRunner@gmail.com" },
                  new ContactModel { FirstName = "Jack", LastName = "Harkness", CellPhone = "0820000013", Email = "Torchwood@gmail.com" },
                  new ContactModel { FirstName = "James", LastName = "T Kirk", CellPhone = "0820000014", Email = "StarTreksaga@gmail.com" },
                  new ContactModel { FirstName = "Jean-Luc", LastName = "Picard", CellPhone = "0820000015", Email = "StarTrekTheNextGeneration@gmail.com" },
                  new ContactModel { FirstName = "Londo", LastName = "Mollari", CellPhone = "0820000016", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "The", LastName = "Alien", CellPhone = "0820000017", Email = "Alien@gmail.com" },
                  new ContactModel { FirstName = "Dana", LastName = "Scully", CellPhone = "0820000018", Email = "TheXFiles@gmail.com" },
                  new ContactModel { FirstName = "Ianto", LastName = "Jones", CellPhone = "0820000019", Email = "Torchwood@gmail.com" },
                  new ContactModel { FirstName = "Yoda", LastName = "Yoda", CellPhone = "0820000020", Email = "StarWarssaga@gmail.com" },
                  new ContactModel { FirstName = "Aeryn", LastName = "Sun", CellPhone = "0820000021", Email = "Farscape@gmail.com" },
                  new ContactModel { FirstName = "Kara", LastName = "Thrace", CellPhone = "0820000022", Email = "BattlestarGalactica@gmail.com" },
                  new ContactModel { FirstName = "Sarah", LastName = "Connor", CellPhone = "0820000023", Email = "TheTerminatorsaga@gmail.com" },
                  new ContactModel { FirstName = "Doc", LastName = "Brown", CellPhone = "0820000024", Email = "BacktotheFuturetrilogy@gmail.com" },
                  new ContactModel { FirstName = "Fox", LastName = "Mulder", CellPhone = "0820000025", Email = "TheXFiles@gmail.com" },
                  new ContactModel { FirstName = "Bernard", LastName = "Quatermass", CellPhone = "0820000026", Email = "QuatermassandthePit@gmail.com" },
                  new ContactModel { FirstName = "The", LastName = "Terminator", CellPhone = "0820000027", Email = "TheTerminatorsaga@gmail.com" },
                  new ContactModel { FirstName = "Susan", LastName = "Ivanova", CellPhone = "0820000028", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "John", LastName = "Sheridan", CellPhone = "0820000029", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "Delenn", LastName = "Delenn", CellPhone = "0820000030", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "Jack", LastName = "ONeill", CellPhone = "0820000031", Email = "StargateSG1@gmail.com" },
                  new ContactModel { FirstName = "Daleks", LastName = "Daleks", CellPhone = "0820000032", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Data", LastName = "Data", CellPhone = "0820000033", Email = "StarTrekTheNextGeneration@gmail.com" },
                  new ContactModel { FirstName = "Luke", LastName = "Skywalker", CellPhone = "0820000034", Email = "StarWarssaga@gmail.com" },
                  new ContactModel { FirstName = "Gort", LastName = "Klaatu", CellPhone = "0820000035", Email = "TheDaytheEarthStoodStill@gmail.com" },
                  new ContactModel { FirstName = "Maria", LastName = "Robot", CellPhone = "0820000036", Email = "Metropolis@gmail.com" },
                  new ContactModel { FirstName = "Judge", LastName = "Dredd", CellPhone = "0820000037", Email = "JudgeDredd@gmail.com" },
                  new ContactModel { FirstName = "ET", LastName = "ET", CellPhone = "0820000038", Email = "ETTheExtraTerrestrial@gmail.com" },
                  new ContactModel { FirstName = "Ben", LastName = "Kenobi", CellPhone = "0820000039", Email = "StarWarssaga@gmail.com" },
                  new ContactModel { FirstName = "Neo", LastName = "Neo", CellPhone = "0820000040", Email = "TheMatrixtrilogy@gmail.com" },
                  new ContactModel { FirstName = "Robbie", LastName = "Robot", CellPhone = "0820000041", Email = "ForbiddenPlanet@gmail.com" },
                  new ContactModel { FirstName = "Marvin", LastName = "the Paranoid Android", CellPhone = "0820000042", Email = "TheHitchhikersGuidetotheGalaxy@gmail.com" },
                  new ContactModel { FirstName = "Marty", LastName = "McFly", CellPhone = "0820000043", Email = "BacktotheFuturetrilogy@gmail.com" },
                  new ContactModel { FirstName = "Rose", LastName = "Tyler", CellPhone = "0820000044", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Samantha", LastName = "Carter", CellPhone = "0820000045", Email = "StargateSG1@gmail.com" },
                  new ContactModel { FirstName = "Donna", LastName = "Noble", CellPhone = "0820000046", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Walter", LastName = "Bishop", CellPhone = "0820000047", Email = "Fringe@gmail.com" },
                  new ContactModel { FirstName = "William", LastName = "Adama", CellPhone = "0820000048", Email = "BattlestarGalactica@gmail.com" },
                  new ContactModel { FirstName = "River", LastName = "Tam", CellPhone = "0820000049", Email = "FireflySerenity@gmail.com" },
                  new ContactModel { FirstName = "Arthur", LastName = "Dent", CellPhone = "0820000050", Email = "TheHitchhikersGuidetotheGalaxy@gmail.com" },
                  new ContactModel { FirstName = "Wall-E", LastName = "Wall-E", CellPhone = "0820000051", Email = "WallE@gmail.com" },
                  new ContactModel { FirstName = "R2-D2", LastName = "R2-D2", CellPhone = "0820000052", Email = "StarWars@gmail.com" },
                  new ContactModel { FirstName = "Boba", LastName = "Fett", CellPhone = "0820000053", Email = "StarWars@gmail.com" },
                  new ContactModel { FirstName = "Arnold", LastName = "J Rimmer", CellPhone = "0820000054", Email = "RedDwarf@gmail.com" },
                  new ContactModel { FirstName = "Sam", LastName = "Bell", CellPhone = "0820000055", Email = "Moon@gmail.com" },
                  new ContactModel { FirstName = "Leeloo", LastName = "Leeloo", CellPhone = "0820000056", Email = "TheFifthElement@gmail.com" },
                  new ContactModel { FirstName = "Roj", LastName = "Blake", CellPhone = "0820000057", Email = "Blakes7@gmail.com" },
                  new ContactModel { FirstName = "Elim", LastName = "Garak", CellPhone = "0820000058", Email = "StarTrekDeepSpaceNine@gmail.com" },
                  new ContactModel { FirstName = "Scorpius", LastName = "Scorpius", CellPhone = "0820000059", Email = "Farscape@gmail.com" },
                  new ContactModel { FirstName = "Thomas", LastName = "Jerome Newton", CellPhone = "0820000060", Email = "TheManWhoFelltoEarth@gmail.com" },
                  new ContactModel { FirstName = "Kathryn", LastName = "Janeway", CellPhone = "0820000061", Email = "StarTrekVoyager@gmail.com" },
                  new ContactModel { FirstName = "Gaius", LastName = "Baltar", CellPhone = "0820000062", Email = "BattlestarGalactica@gmail.com" },
                  new ContactModel { FirstName = "Chiana", LastName = "Chiana", CellPhone = "0820000063", Email = "Farscape@gmail.com" },
                  new ContactModel { FirstName = "Kaylee", LastName = "Kaylee", CellPhone = "0820000064", Email = "FireflySerenity@gmail.com" },
                  new ContactModel { FirstName = "Sarah-Jane", LastName = "Smith", CellPhone = "0820000065", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "David", LastName = "David", CellPhone = "0820000066", Email = "Prometheus@gmail.com" },
                  new ContactModel { FirstName = "Q", LastName = "Q", CellPhone = "0820000067", Email = "StarTreksaga@gmail.com" },
                  new ContactModel { FirstName = "Dave", LastName = "Lister", CellPhone = "0820000068", Email = "RedDwarf@gmail.com" },
                  new ContactModel { FirstName = "Amy", LastName = "Pond", CellPhone = "0820000069", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Flash", LastName = "Gordon", CellPhone = "0820000070", Email = "FlashGordon@gmail.com" },
                  new ContactModel { FirstName = "Leia", LastName = "Organa", CellPhone = "0820000071", Email = "StarWarssaga@gmail.com" },
                  new ContactModel { FirstName = "RoboCop", LastName = "RoboCop", CellPhone = "0820000072", Email = "RoboCop@gmail.com" },
                  new ContactModel { FirstName = "River", LastName = "Song", CellPhone = "0820000073", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Snake", LastName = "Plissken", CellPhone = "0820000074", Email = "EscapefromNewYork@gmail.com" },
                  new ContactModel { FirstName = "Alfred", LastName = "Bester", CellPhone = "0820000075", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "Barbarella", LastName = "Barbarella", CellPhone = "0820000076", Email = "Barbarella@gmail.com" },
                  new ContactModel { FirstName = "John", LastName = "Sheppard", CellPhone = "0820000077", Email = "StargateAtlantis@gmail.com" },
                  new ContactModel { FirstName = "Seven", LastName = "of Nine", CellPhone = "0820000078", Email = "StarTrekVoyager@gmail.com" },
                  new ContactModel { FirstName = "Daniel", LastName = "Jackson", CellPhone = "0820000079", Email = "StargateSG1@gmail.com" },
                  new ContactModel { FirstName = "RJ", LastName = "MacReady", CellPhone = "0820000080", Email = "TheThing@gmail.com" },
                  new ContactModel { FirstName = "Dave", LastName = "Bowman", CellPhone = "0820000081", Email = "2001ASpaceOdyssey@gmail.com" },
                  new ContactModel { FirstName = "Jeffrey", LastName = "Sinclair", CellPhone = "0820000082", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "Lyta", LastName = "Alexander", CellPhone = "0820000083", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "Tetsuo", LastName = "Shima", CellPhone = "0820000084", Email = "Akira@gmail.com" },
                  new ContactModel { FirstName = "The", LastName = "Predator", CellPhone = "0820000085", Email = "Predator@gmail.com" },
                  new ContactModel { FirstName = "Benjamin", LastName = "Sisko", CellPhone = "0820000086", Email = "StarTrekDeepSpaceNine@gmail.com" },
                  new ContactModel { FirstName = "Gwen", LastName = "Cooper", CellPhone = "0820000087", Email = "Torchwood@gmail.com" },
                  new ContactModel { FirstName = "Kryten", LastName = "Kryten", CellPhone = "0820000088", Email = "RedDwarf@gmail.com" },
                  new ContactModel { FirstName = "Servalan", LastName = "Servalan", CellPhone = "0820000089", Email = "Blakes7@gmail.com" },
                  new ContactModel { FirstName = "The", LastName = "Master", CellPhone = "0820000090", Email = "DoctorWho@gmail.com" },
                  new ContactModel { FirstName = "Vala", LastName = "Mal Doran", CellPhone = "0820000091", Email = "StargateSG1@gmail.com" },
                  new ContactModel { FirstName = "Bo", LastName = "Dennis", CellPhone = "0820000092", Email = "LostGirl@gmail.com" },
                  new ContactModel { FirstName = "Michael", LastName = "Garibaldi", CellPhone = "0820000093", Email = "Babylon5@gmail.com" },
                  new ContactModel { FirstName = "Number", LastName = "Six", CellPhone = "0820000094", Email = "BattlestarGalactica@gmail.com" },
                  new ContactModel { FirstName = "Hoban", LastName = "Wash Washburn", CellPhone = "0820000095", Email = "FireflySerenity@gmail.com" },
                  new ContactModel { FirstName = "C3PO", LastName = "C3PO", CellPhone = "0820000096", Email = "StarWars@gmail.com" },
                  new ContactModel { FirstName = "Riddick", LastName = "Riddick", CellPhone = "0820000097", Email = "TheChroniclesofRiddick@gmail.com" },
                  new ContactModel { FirstName = "Motoko", LastName = "Kusanagi", CellPhone = "0820000098", Email = "GhostintheShell@gmail.com" },
                  new ContactModel { FirstName = "Laura", LastName = "Roslin", CellPhone = "0820000099", Email = "BattlestarGalactica@gmail.com" },
                  new ContactModel { FirstName = "Doctor", LastName = "Ellie Arroway", CellPhone = "0820000100", Email = "Contact@gmail.com" },
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
