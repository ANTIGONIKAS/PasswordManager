using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.Services {
    public class SessionState {

        private bool _IsLoggedIn { get; set; }
        private Guid _UserID { get; set; }
        public event Action OnChange;


        public bool IsLoggedIn {
            get { return _IsLoggedIn; }
            set {
                if (_IsLoggedIn != value) {
                    _IsLoggedIn = value;
                    NotifyStateChanged();
                }
            }
        }
        public Guid UserID {
            get { return _UserID; }
            set {
                if (_UserID != value) {
                    _UserID = value;
                    NotifyStateChanged();
                }
            }
        }
        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
