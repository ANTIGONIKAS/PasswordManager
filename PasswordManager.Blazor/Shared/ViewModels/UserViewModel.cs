using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordManager.Blazor.Shared.User {
    public class UserViewModel {


        [Required]
        [MaxLength(20, ErrorMessage = " Max length 20 characters.")]
        public string? FName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = " Max length 20 characters.")]
        public string? LName { get; set; }

        public string? MasterUsername { get; set; }
        public string? MasterPassword { get; set; }
        public string? Email { get; set; }

        public List<Password> Passwords { get; set; } = new();
    }

    
}
