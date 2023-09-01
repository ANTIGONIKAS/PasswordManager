using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.ViewModels {
    public class LoginViewModel {

        [Required]
        public string? MasterUserName { get; set; }
        [Required]
        public string? MasterPassword { get; set; }


    }
}
