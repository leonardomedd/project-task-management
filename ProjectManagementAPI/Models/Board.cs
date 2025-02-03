namespace ProjectManagementAPI.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicializando com valor padrão
        public List<Task> Tasks { get; set; } = new List<Task>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}