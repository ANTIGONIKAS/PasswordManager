namespace PasswordManager.Model {
    public class Password {

        public Guid Id { get; set; }
        public string? Site { get; set; }
        public string? Username { get; set; }
        public string? Passcode { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

       
    }

}