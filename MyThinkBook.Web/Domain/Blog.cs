using System.Diagnostics.CodeAnalysis;

namespace MyThinkBook.Web.Domain;

[ExcludeFromCodeCoverage]
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; } = string.Empty;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public List<Post> Posts { get; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

[ExcludeFromCodeCoverage]
public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public DateTime CreatedDateTime { get; set; }

    public int BlogId { get; set; }
    public Blog? Blog { get; set; }
}


//public class Name
//{
//    public virtual string First { get; set; }
//    public virtual string Last { get; set; }
//}

//public class Blog
//{
//    public int BlogId { get; set; }
//    public string Url { get; set; }

//    public virtual ICollection<Post> Posts { get; set; }
//}
//public class Post
//{
//    public int PostId { get; set; }
//    public string Content { get; set; }
//    public string Title { get; set; }
//    public int BlogId { get; set; }
//    public Blog Blog { get; set; }
//    public Name AuthorName { get; set; }
//}
