namespace lab.data
{
    using System;
    using System.Data.Entity;   
    using System.Linq;
    using lab.core.Domain;
    

    public partial class LabContext : DbContext
    {
        public LabContext()
            : base("name=LabContext")
        {
        }

        public static DbSet<Author> Authors { get; set; }
        public static DbSet<Course> Courses { get; set; }
        public static DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Authors)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id").MapRightKey("Tag_Id"));
        }
    }
}
