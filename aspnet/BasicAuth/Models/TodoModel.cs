namespace BasicAuth.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string Task { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
    }
}
