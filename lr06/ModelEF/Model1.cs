using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lr06.Model1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<kv> kv { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
