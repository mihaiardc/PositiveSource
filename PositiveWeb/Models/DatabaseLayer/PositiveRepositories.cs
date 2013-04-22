using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using PositiveBussinesModel.Content.PublishingItems;
using PositiveBussinesModel.Members;

namespace PositiveWeb.Models.DatabaseLayer
{
    public class PositiveRepositories : DbContext 
    {
        public PositiveRepositories()
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         

            modelBuilder.Entity<Article>().
      HasMany(c => c.Users).
      WithMany(p => p.JoinedGroups);


        }
    }
}