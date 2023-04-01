using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.Services {
    public class Validator {
        /// <summary>
        /// The Basic use of Validator Class is
        /// to be able to create a list of validations
        /// for varius things we need to parse
        /// 
        /// </summary>


        public bool ValidateName(string name) {
            return false;
        }

        public bool ValidateSurname(string surname) { 
            return false;
        }

        public bool ValidatePassword(string password) { 
            return false;
        }
        public bool ValidateEmail(string email) {
            return false;
        }
        public bool ValidatePhone(string phone) { 
            return false; 
        }
        /*
         *There should be a generic validator that calls all other validators in one
         */
    }
}
