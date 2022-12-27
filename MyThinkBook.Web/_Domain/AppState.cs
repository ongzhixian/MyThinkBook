using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThinkBook.Web.Domain;

[Table("app_state_item")]
public record AppStateItem
{
    [Key]
    public string Key { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;
}
