namespace TeamManager.UI.Models
{
    public record Attendance(
        int EventId,
        int AttendanceId,
        string LastName,
        string FirstName,
        string Category,
        bool Present,
        string Notes
        );

    public record AttendanceResponse(List<Attendance> Attendances);
}
