using System;

namespace TodoAppClient
{
    public class TodoItem
    {
        public string Text { get; set; }
        public bool Complete { get; set; }
        public string Id { get; set; }
        public string Version { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }
    }
}
