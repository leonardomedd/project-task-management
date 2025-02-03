namespace ProjectManagementAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; // Inicializando com valor padrão
        public string Description { get; set; } = string.Empty; // Inicializando com valor padrão
        public int BoardId { get; set; }
        public Board Board { get; set; } = new Board(); // Inicializando com valor padrão
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}