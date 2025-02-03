public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } // To-Do, Em Progresso, Concluído
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}