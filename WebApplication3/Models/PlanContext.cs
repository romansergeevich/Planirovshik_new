using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class PlanContext:DbContext

    {
        public PlanContext()
           : base("name=PlanContext")
        {
        }

        public DbSet<Plan> Plans { get; set; }
    }
    public class PlanDbInitializer : DropCreateDatabaseAlways<PlanContext>
    {
        protected override void Seed(PlanContext db)
        {
            db.Plans.Add(new Plan {Den = 13.09,PlanNaden="Поход в магазин" });
            base.Seed(db);

        }


    }
}