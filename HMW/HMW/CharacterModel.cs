namespace HMW
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CharacterModel : DbContext
    {
        public CharacterModel()
            : base("name=CharacterModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Universe> Universes { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Friends> Friendss { get; set; }
        public virtual DbSet<Foe> Foes { get; set; }

    }
}
