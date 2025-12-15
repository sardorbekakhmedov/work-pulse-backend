namespace WorkPulse.Domain.Entities.Base;

public class BaseEntity<T>
{
    public T Id { get; set; } = default!;
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public bool IsDeleted { get; set; }
}