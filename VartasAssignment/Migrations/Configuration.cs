namespace VartasAssignment.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;
    using VartasAssignment.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VartasAssignment.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VartasAssignment.Models.GameDBContext context)
        {
            
        }
    }
}
