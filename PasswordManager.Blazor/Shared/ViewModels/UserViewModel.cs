using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-aspnet-mvc3/cs/adding-validation-to-the-model


namespace PasswordManager.Blazor.Shared.User {
    public class UserViewModel {


        [Required]
        [MaxLength(20, ErrorMessage = " Max length 20 characters.")] 
        public string? FName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = " Max length 20 characters.")]
        public string? LName { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "Master Username max length is 50 characters")]
        public string? MasterUsername { get; set; }
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,16}$", ErrorMessage = "Password Must Have a lower,upper,number and a special character.")]
        public string? MasterPassword { get; set; }
        public string? Email { get; set; }

        public List<Password> Passwords { get; set; } = new();
    }

    
}
