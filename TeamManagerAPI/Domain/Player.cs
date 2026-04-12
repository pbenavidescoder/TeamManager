namespace TeamManagerAPI.Domain
{
   public class Player 
   {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Category { get; set; }
        public PlayerPosition Position { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public PlayerStatus Status { get; set; }
        public DateTime JoinDate { get; set; }
        public string? AvatarPath { get; set; }
        public string? Jersey { get; set; }
        public string? Notes { get; set; }
   }

}
