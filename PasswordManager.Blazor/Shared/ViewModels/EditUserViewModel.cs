using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.ViewModels {
    public class EditUserViewModel {

        public Guid Id { get; set; }

        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? MasterUsername { get; set; }
        public string? MasterPassword { get; set; }
        public string? Email { get; set; }
    }
}
