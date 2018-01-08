using System;

namespace ToDoList
{
    public class ToDoItem
    {
        public string Description { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public override string ToString() => $"{Description} {CreatedAt}";
    }
}