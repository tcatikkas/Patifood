using PatifoodDataModel.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel.Context
{
    public class PatifoodDataDbInitializer : DropCreateDatabaseIfModelChanges<PatifoodDataContext>
    {
        protected override void Seed(PatifoodDataContext context)
        {
            base.Seed(context);

            DbContextUtil.ApplyDbAttributesToDb(context);

            context.SaveChanges();
        }


        public void SeedPublic(PatifoodDataContext context)
        {
            this.Seed(context);

        }
    }
}
