namespace PasswordManager.Win {
    public partial class LoginF : Form {
        public LoginF() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            /*
             1. 8a tsekarei stin vasi an iparxnoi ta stoixeia
            1.1 an den yparxoun vgale error
            1.2 an uparxoun ferta kai kalese tin forma home*/
            Guid userid = Guid.NewGuid(); //auto einai to guid pou exoume ferei apo ton user
            var homeF = new HomeF(userid);
            homeF.ShowDialog();
        }
    }
}