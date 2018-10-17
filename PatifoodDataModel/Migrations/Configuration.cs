using PatifoodDataModel.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<PatifoodDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PatifoodDataContext context)
        {
            base.Seed(context);

            DbContextUtil.ApplyDbAttributesToDb(context);

            context.SaveChanges();
        }

        public void SeedPublic(PatifoodDataContext ctx)
        {
            Seed(ctx);
        }
    }
}
