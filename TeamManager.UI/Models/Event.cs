namespace TeamManager.UI.Models
{
    public record Event(
      int EventId,
      Activity EventType,
      DateTime Date,
      string Location,
      string Description
  );


    //public record EventAttendanceResponse(
    //    List<Event> Events,
    //    List<Attendance> Attendances
    //);

    public record EventResponse(List<Event> Events);

}
