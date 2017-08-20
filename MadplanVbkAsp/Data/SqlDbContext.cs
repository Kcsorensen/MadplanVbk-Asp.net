using MadplanVbkAsp.Models;
using Microsoft.EntityFrameworkCore;

namespace MadplanVbkAsp.Data
{
    //public class Course
    //{
    //    public int CourseId { get; set; }
    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //    //public CourseLevel Level { get; set; }
    //    public float FullPrice { get; set; }

    //    [ForeignKey("AuthorId")]
    //    public Author Author { get; set; }
    //    public ICollection<CourseTag> CourseTags { get; set; }
    //}

    //public class Author
    //{

    //    public int AuthorId { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<Course> Courses { get; set; }

    //}

    //public class Tag
    //{
    //    public int TagId { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<CourseTag> CourseTags { get; set; }
    //}

    //public class CourseTag
    //{
    //    public int CourseTagId { get; set; }

    //    public int CourseId { get; set; }
    //    public Course Course { get; set; }

    //    public int TagId { get; set; }
    //    public Tag Tag { get; set; }
    //}

    //public enum CourseLevel
    //{
    //    Beginner = 1,
    //    Itermediate = 2,
    //    Advanced = 3
    //}

    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        { }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Tag> Tags { get; set; }

        public DbSet<Food> Foods { get; set; }
        public DbSet<QuantityConverter> QuantityConverters { get; set; }
        public DbSet<Quantity> Quantities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .HasOne(a => a.QuantityConverter);

            modelBuilder.Entity<QuantityConverter>()
                .HasMany(a => a.Quantities);
            

            base.OnModelCreating(modelBuilder);
        }


    }
}
