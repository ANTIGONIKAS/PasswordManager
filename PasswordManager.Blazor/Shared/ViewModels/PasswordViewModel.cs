using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.ViewModels
{
    public class PasswordViewModel
    {

        public Guid Id { get; set; }
        public string? Site { get; set; }
        public string? Username { get; set; }
        public string? Passcode { get; set; }

        public Guid UserId { get; set; }

       
    }
}
