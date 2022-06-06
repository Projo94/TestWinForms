using System;
using System.Windows.Forms;
using TestWinForms.Data;
using TestWinForms.Models;

namespace TestWinForms.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            SetupFields();
            StyleForm();
        }

        private void StyleForm()
        {
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetupFields()
        {
            txtUsername.Properties.MaxLength = 20;
            txtPassword.Properties.MaxLength = 20;
            txtPassword.Properties.PasswordChar = '*';
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoginToSystem();
        }

        private void LoginToSystem()
        {
            var user = new User();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;

            var exist = false;

            try
            {
                exist = DataAccess.CheckUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show($" An error happend while login.\n Error details: {ex.Message}", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (exist)
            {
                Hide();
                var frmMain = new frmMain();
                frmMain.StartPosition = FormStartPosition.CenterScreen;
                frmMain.TopMost = true;
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password or username incorrect.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
