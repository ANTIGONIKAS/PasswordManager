using PasswordManager.Blazor.Shared.ViewModels.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.Services {
    public class Authenticator {
        public UserEntryViewModel Authenticate ( List<UserEntryViewModel> lista, UserEntryViewModel login) {

            foreach(var user in lista) {
                if(user.MasterPassword== login.MasterPassword && user.MasterUserName==login.MasterUserName) {
                    return user;
                }
            }
            return null;
        }
    }
}
