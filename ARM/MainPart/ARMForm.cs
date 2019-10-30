using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ARM.Authentication;
using ARM.Management;
using ARM.LinguisticDBModel;
using ARM.StandardQueries;

namespace ARM.MainPart
{
    public partial class ArmForm : Form
    {
        string _userLogin;

        public ArmForm()
        {
            InitializeComponent();
        }

        private void ARMForm_Load(object sender, EventArgs e)
        {
            userLoginStatus.Tag = MainLocalization.UserLoginBase;
            userRoleStatus.Tag = MainLocalization.UserRoleBase;
            AuthenticateUser();
            using (var context = new LinguisticModel())
            {
                var macroList = new List<Языковые_макросемьи> {new Языковые_макросемьи()};
                macroList.AddRange(context.Языковые_макросемьи.ToList());
                langMacroFamsBindingSource.DataSource = macroList;
                langFamsBindingSource.DataSource = context.Языковые_семьи.ToList();
                langsBindingSource.DataSource = context.Языки.ToList();
                ethnoOrgsBindingSource.DataSource = context.Этнографические_организации.ToList();
                langsCountBindingSource.DataSource = context.Число_носителей_языков.ToList();
            }
        }

        private void AuthenticateUser()
        {
            var authenticationForm = new AuthenticationForm();
            authenticationForm.Focus();
            if (authenticationForm.ShowDialog() == DialogResult.OK)
            {
                Focus();
                var userType = authenticationForm.UserType;
                _userLogin = authenticationForm.UserLogin;
                authenticationForm.Dispose();
                switch (userType)
                {
                    case AuthenticationForm.UserTypes.Admin:
                        {
                            SetGui(true, true);
                            SetUserStatus(MainLocalization.AdminRole);
                            break;
                        }
                    case AuthenticationForm.UserTypes.User:
                        {
                            SetGui(false, true);
                            SetUserStatus(MainLocalization.OperatorRole);
                            break;
                        }
                    case AuthenticationForm.UserTypes.Guest:
                        {
                            SetGui(false, false);
                            SetUserStatus(MainLocalization.GuestRole);
                            break;
                        }
                }
            }
            else Close();
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            Visible = false;
            AuthenticateUser();
            if (!IsDisposed)
                Visible = true;
        }

        private void usersManagement_Click(object sender, EventArgs e)
        {
            Visible = false;
            var managementForm = new ManagementForm(_userLogin);
            managementForm.Focus();
            using (managementForm)
            {
                managementForm.ShowDialog(this);
                _userLogin = managementForm.AdminLogin;
            }
            Focus();
            Visible = true;
        }

        private void SetUserStatus(string role)
        {
            userLoginStatus.Text = $"{userLoginStatus.Tag as string} {_userLogin}.";
            userRoleStatus.Text = $"{userRoleStatus.Tag as string} {role}.";
        }

        private void SetGui(bool isAdminRole, bool isOperatorRole)
        {
            usersManagement.Enabled = isAdminRole;
            usersManagement.Visible = isAdminRole;
            SetDGVAccess(ethnoOrgsDGV, isOperatorRole);
            SetDGVAccess(langsCountDGV, isOperatorRole);
            SetDGVAccess(langsDGV, isOperatorRole);
            SetDGVAccess(langFamsDGV, isOperatorRole);
        }

        private void SetDGVAccess(DataGridView dgv, bool access)
        {
            dgv.AllowUserToDeleteRows = access;
            dgv.AllowUserToAddRows = access;
            dgv.ReadOnly = !access;
        }

        private void recentEthnoOrgsButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (var ethnoOrgForm = new RecentEthnoOrgsForm())
            {
                ethnoOrgForm.Focus();
                ethnoOrgForm.ShowDialog(this);
            }
            Focus();
            Visible = true;
        }

        private void upToDateLangInfoButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (var langInfoForm = new UpToDateLangInfoForm())
            {
                langInfoForm.Focus();
                langInfoForm.ShowDialog(this);
            }
            Focus();
            Visible = true;
        }

        private void ArmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            langsDGV.DataSource = null;
            ethnoOrgsDGV.DataSource = null;
            langsCountDGV.DataSource = null;
            langFamsDGV.DataSource = null;
        }
    }
}