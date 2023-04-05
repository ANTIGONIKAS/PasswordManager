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
    public partial class HomeF : Form {

        private Guid _userId;
        public HomeF(Guid IncomingUserID) {
            _userId = IncomingUserID;
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            var createF = new EditPasswordF(_userId);
            createF.ShowDialog();
        }
    }
}
