using WorkPulse.Domain.Entities.Base;

namespace WorkPulse.Domain.Entities.Auth;

public class AuthSession : BaseEntity<long>
{
    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public string OtpHash { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }
    public bool IsVerified { get; set; } = false;

    public int AttemptCount { get; set; } = 0;

    public string? IpAddress { get; set; }
    public string? UserDevice { get; set; }
}
