using WorkPulse.Domain.Entities.Base;
using WorkPulse.Domain.Enums;

namespace WorkPulse.Domain.Entities;

public class Notification : BaseEntity<long>
{
    public required string Title { get; set; }
    public required string Message { get; set; }

    public NotificationType Type { get; set; }
}
