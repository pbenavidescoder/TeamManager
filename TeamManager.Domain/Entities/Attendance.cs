using TeamManager.Domain.Enum;

namespace TeamManager.Domain.Entities
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeRecorded { get; set; }
        public int PlayerId { get; set; }

        public bool Present { get; set; }
        public Activity ActivityType { get; set; }
        public string Remarks { get; set; }
        public string RecordedBy { get; set; }

    }
}
