using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using Mvc5_Boilerplate.Core.Domain;
using TrackerEnabledDbContext.Identity;

namespace Mvc5_Boilerplate.Persistence
{
    public class Mvc5BoilerPlateContext : TrackerIdentityContext<ApplicationUser>
    {
        public Mvc5BoilerPlateContext()
            : base("DefaultConnection")
        {
        }

        public static Mvc5BoilerPlateContext Create()
        {
            return new Mvc5BoilerPlateContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}