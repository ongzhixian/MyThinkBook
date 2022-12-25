﻿namespace MyThinkBook.Web.Domain;

public record Book
{
    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;
}
