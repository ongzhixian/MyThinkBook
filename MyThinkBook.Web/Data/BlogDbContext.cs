using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public class BlogDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }

    public DbSet<Post> Posts { get; set; }

    //public string DbPath { get; }

    public BlogDbContext(DbContextOptions<BlogDbContext> options)
           : base(options)
    {
        //var folder = Environment.SpecialFolder.LocalApplicationData;
        //var path = Environment.GetFolderPath(folder);
        //DbPath = System.IO.Path.Join(path, "blog.sqlite");
    }


    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
}

//internal sealed class Configuration : DbMigrationsConfiguration<ContosoUniversity.DAL.SchoolContext>
//{
//    public Configuration()
//    {
//        AutomaticMigrationsEnabled = false;
//    }

//    protected override void Seed(ContosoUniversity.DAL.SchoolContext context)
//    {
//        //  This method will be called after migrating to the latest version.

//        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//        //  to avoid creating duplicate seed data. E.g.
//        //
//        //    context.People.AddOrUpdate(
//        //      p => p.FullName,
//        //      new Person { FullName = "Andrew Peters" },
//        //      new Person { FullName = "Brice Lambson" },
//        //      new Person { FullName = "Rowan Miller" }
//        //    );
//        //
//    }
//}

public static class BlogContextInitializer
{
    public static void Initialize(BlogDbContext context)
    {
        if (context.Blogs.Any())
        {
            return;
        }

        //var blogs = new Blog[]
        //{
        //    new Blog()
        //    {
        //        Posts = new[]
        //        {
        //            new Post() { Title = "someTitle", Content},
        //            new Post() {}

        //        }
        //    }
        //};

        //context.Blogs.AddRange(blogs);

        //var students = new Student[]
        //{
        //        new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
        //        new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
        //        new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
        //        new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
        //        new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
        //        new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
        //        new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
        //        new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
        //};

        //context.Students.AddRange(students);
        //context.SaveChanges();

        //var courses = new Course[]
        //{
        //    new Course{CourseID=1050,Title="Chemistry",Credits=3},
        //    new Course{CourseID=4022,Title="Microeconomics",Credits=3},
        //    new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
        //    new Course{CourseID=1045,Title="Calculus",Credits=4},
        //        new Course{CourseID=3141,Title="Trigonometry",Credits=4},
        //        new Course{CourseID=2021,Title="Composition",Credits=3},
        //        new Course{CourseID=2042,Title="Literature",Credits=4}
        //};

        //context.Courses.AddRange(courses);
        //context.SaveChanges();
        //var enrollments = new Enrollment[]
        //{
        //        new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
        //        new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
        //        new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
        //        new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
        //        new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
        //        new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
        //        new Enrollment{StudentID=3,CourseID=1050},
        //    new Enrollment{StudentID=4,CourseID=1050},
        //        new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
        //        new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
        //    new Enrollment{StudentID=6,CourseID=1045},
        //        new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
        //};

        //context.Enrollments.AddRange(enrollments);
        //context.SaveChanges();
    }
}
