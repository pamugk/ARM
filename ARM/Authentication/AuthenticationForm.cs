using System;
using System.Linq;
using System.Windows.Forms;
using ARM.UsersDBModel;

namespace ARM.Authentication
{
    public partial class AuthenticationForm : Form
    {
        public enum UserTypes
        {
            Admin,
            User,
            Guest
        }

        public string UserLogin { get; private set; }
        public UserTypes UserType { get; private set; }

        public AuthenticationForm()
        {
            InitializeComponent();
            SetControlText(loginLabel, AuthenticationLocalization.LoginLabelText);
            SetControlText(passwordLabel, AuthenticationLocalization.PasswordLabelText);
            ChangeShowPasswordButtonImage();
            using (var context = new UsersModel())
                usersComboBox.DataSource = context.Пользователи.ToList();
            SetAuthenticationGui();
            SetAuthenticationEventHandlers();
        }
        
        private void ChangeLoginLayout(Control oldElement, Control newElement)
        {
            oldElement.Visible = false;
            loginTableLayout.Controls.Remove(oldElement);
            loginTableLayout.Controls.Add(newElement, 1, 0);
            newElement.Visible = true;
        }

        private static void ChangeTextBoxTextChangedEventHandler(TextBox textBox, EventHandler oldTextChangedEventHandler, EventHandler newTextChangedEventHandler)
        {
            textBox.TextChanged -= oldTextChangedEventHandler;
            textBox.TextChanged += newTextChangedEventHandler;
        }

        private static void ChangeButtonClickEventHandler(Button button, EventHandler oldClickEventHandler, EventHandler newClickEventHandler)
        {
            button.Click -= oldClickEventHandler;
            button.Click += newClickEventHandler;
        }

        private static void SetControlText(Control control, string newText)
        {
            control.Text = newText;
        }

        private void AllowFinish()
        {
            finishButton.Enabled = true;
        }

        private void ForbidFinish()
        {
            finishButton.Enabled = false;
        }

        private void ResetUserInput()
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            guestCheckBox.Checked = false;
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
            ChangeShowPasswordButtonImage();
        }

        private void ChangeShowPasswordButtonImage()
        {
            showPasswordButton.Image = passwordTextBox.UseSystemPasswordChar
                                        ? Images.closedEye
                                        : Images.openedEye;
        }

        private void guestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            usersComboBox.Enabled = !guestCheckBox.Checked;
            passwordTextBox.Text = "";
            passwordTextBox.Enabled = !guestCheckBox.Checked;
            finishButton.Enabled = guestCheckBox.Checked;
        }
    }    
}