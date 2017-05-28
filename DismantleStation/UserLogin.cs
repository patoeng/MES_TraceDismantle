using System;
using System.Windows.Forms;

namespace DismantleStation
{
    public partial class UserLogin : Form
    {
        private readonly string _databaseConnection;
        private readonly Settings1 _settings = new Settings1();
        public UserLogin()
        {
            InitializeComponent();
            _databaseConnection = _settings.DbConnection;
        }

        public int LoginResult;

        public void Initialize()
        {
            var nameList = Enum.GetNames(typeof(UserLevels));
            foreach (var name in nameList)
            {
                cbUserRole.Items.Add(name);
            }
            cbUserRole.SelectedIndex = 0;
        }
        private void UserLogin_Load(object sender, System.EventArgs e)
        {
            Initialize();
        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginResult = -1;
            Close();
        }

        private void UserLogin_Shown(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Login();
            }
        }

        private void Login()
        {
            LoginResult = UserControlsHelper.LoginCheck(cbUserRole.SelectedIndex, tbPassword.Text, _databaseConnection);
            if (LoginResult == cbUserRole.SelectedIndex)
            {
                Close();
            }
            else
            {
                MessageBox.Show(@"Login Failed", @"Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
