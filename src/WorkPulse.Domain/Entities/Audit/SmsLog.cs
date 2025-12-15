using WorkPulse.Domain.Entities.Auth;
using WorkPulse.Domain.Entities.Base;

namespace WorkPulse.Domain.Entities.Audit;

public class SmsLog : BaseEntity<long>
{
    public required string Phone { get; set; }
    public required string Message { get; set; }
    public int UserId { get; set; }
    public virtual User? User { get; set; }
    public bool IsDelivered { get; set; }
}
