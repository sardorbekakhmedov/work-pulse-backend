using WorkPulse.Domain.Entities.Base;

namespace WorkPulse.Domain.Entities.Auth;

public class UserSession : BaseEntity<long>
{
    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public required string RefreshToken { get; set; }

    public required string DeviceId { get; set; } // frontend generatsiya qiladi
    public required string DeviceName { get; set; } // Chrome / Android / iPhone
    public string? IpAddress { get; set; }

    public DateTime LastActivityAt { get; set; }

    public bool IsRevoked { get; set; }
}


