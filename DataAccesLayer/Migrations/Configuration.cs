namespace DataAccesLayer.Migrations
{
    using Entities.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccesLayer.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataAccesLayer.Context context)
        {
            context.AdminTypes.AddOrUpdate(m => m.ID, new AdminType() { ID = 1, Name = "Yönetici" });
            context.AdminTypes.AddOrUpdate(m => m.ID, new AdminType() { ID = 2, Name = "Moderatör" });

            context.Admins.AddOrUpdate(m => m.ID, new Admin() { ID = 1, AdminType_ID = 1, Name = "Göksel", Surname = "Doğan", Mail = "g_dogan_12@hotmail.com", Password = "1234", Status = true });
        }
    }
}
