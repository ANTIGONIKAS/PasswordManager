using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model {

    public class PasswordEntry: Entry {

        public string Password { get; set; }
        public string UserName { get; set; }
        public string Site { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }

        //relations

        public UserEntry UserEntry { get; set; }
        public Guid UserID { get; set; }

        //ctor

        public PasswordEntry(): base() 
        {

        }

    }
}
