using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.ViewModels.Password {
    public class PasswordViewModel {
        public Guid ID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Site { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }
    }
}
