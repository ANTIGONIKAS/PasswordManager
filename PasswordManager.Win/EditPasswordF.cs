using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Win {
    public partial class EditPasswordF : Form {
        private Guid _userID;
        public EditPasswordF(Guid IncomingUserID) {
            _userID = IncomingUserID;
            InitializeComponent();
        }
    }
}
