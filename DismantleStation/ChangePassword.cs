using System;
using System.Windows.Forms;

namespace DismantleStation
{
    public partial class ChangePassword : Form
    {
        private readonly int _roleId;
        private readonly string _dbConnection = new Settings1().DbConnection;
        public ChangePassword(int roleId)
        {
            InitializeComponent();
            _roleId = roleId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (tbConfirmNewPassword.Text == string.Empty || tbCurrentPassword.Text == string.Empty) return;
            if (!tbNewPassword.Text.Equals(tbConfirmNewPassword.Text))
            {
                MessageBox.Show(@"New Password is not equal", @"Change Password", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            var oldPasswordCheck = UserControlsHelper.LoginCheck(_roleId, tbCurrentPassword.Text, _dbConnection);
            if (oldPasswordCheck != _roleId)
            {
                MessageBox.Show(@"Old Password is not correct!", @"Change Password", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
                return;

            }
            var result = UserControlsHelper.PasswordChange(_roleId, tbNewPassword.Text, _dbConnection);
            Close();
        }
    }
}
