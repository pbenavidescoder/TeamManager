namespace TeamManager.UI.Models
{
    public record Player(
     int PlayerId,
     string FirstName,
     string LastName,
     string Category,
     string Position,
     string Status,
     string Jersey,
     string AvatarPath

 )
    {
        public string FullName => $"{FirstName} {LastName}";
    }

}
