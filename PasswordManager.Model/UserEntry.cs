using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model {

    public class UserEntry:Entry {

        public string MasterUserName { get; set; }
        public string MasterPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }

       

        public List<PasswordEntry> StoredPasswords { get; set; } = new();

        public UserEntry() : base() 
        {
          StoredPasswords= new List<PasswordEntry>();
        }
    }
}
