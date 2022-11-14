using System.ComponentModel.DataAnnotations;
using MyThinkBook.Data.MongoDb;

namespace MyThinkBook.Web.Models;

//public interface IResourceType
//{
//    string Name { get; set; }
//}

//public class ResourceType : IResourceType
//{
//    public string Id { get; set; } = string.Empty;
    
//    public string Name { get; set; } = string.Empty;

//    [DataType(DataType.Date)]
//    public DateTime CreateDate { get; set; }

//    //public string? Genre { get; set; }

//    //public decimal Price { get; set; }
//}



//public record MongoDbResourceType : MongoDbDocument, IResourceType
//{
//    public MongoDbResourceType(string name)
//    {
//        Name = name;
//    }

//    public string Name { get; set; } = string.Empty;
//}