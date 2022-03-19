using System;

namespace ToDoAPI.Models
{
    public record ToDoItem
    {
        public Guid itemID { get; init; } //set on creation only
        public DateTimeOffset createdDate { get; init; }
        public string itemName { get; init; } = "unnamed"; //string? to declare nullible
        public bool completed { get; init; }
    }
}

