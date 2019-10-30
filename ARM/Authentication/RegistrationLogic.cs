using System;
using System.Linq;
using System.Windows.Forms;
using ARM.Security;
using ARM.UsersDBModel;

namespace ARM.Authentication
{
	public partial class AuthenticationForm
	{
		private bool LoginIsNotUsed { get; set; }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "")
            {
                ForbidFinish();
                return;
            }
            using (var context = new UsersModel())
            {
                LoginIsNotUsed = !context.Пользователи.Any(user => user.Логин == loginTextBox.Text);
                if (LoginIsNotUsed)
                {
                    errorProvider.SetError(loginTextBox, string.Empty);
                    if (passwordTextBox.Text != "")
                        AllowFinish();
                    return;
                }
                errorProvider.SetError(loginTextBox,AuthenticationLocalization.RegistrationLoginExistsError);
                LoginIsNotUsed = false;
                ForbidFinish();
            }
        }

        private void PasswordTextBox_TextChanged_OnRegistration(object sender, EventArgs e)
		{
			if (passwordTextBox.Text == "" || !LoginIsNotUsed)
			{
				ForbidFinish();
				return;
			}
			if (loginTextBox.Text != "" && LoginIsNotUsed)
				AllowFinish();
		}

		private void FinishButton_Click_OnRegistration(object sender, EventArgs e)
		{
            using (var context = new UsersModel())
            {
                var salt = PasswordSecurity.GenerateSalt();
                var user = new Пользователи
                {
                    Логин = loginTextBox.Text,
                    Хэш_пароля = PasswordSecurity.GenerateHash(passwordTextBox.Text, salt),
                    Дата_регистрации = DateTime.Now.Date,
                    Соль = salt,
                    Администратор = false
                };
                context.Пользователи.Add(user);
                context.SaveChanges();
                usersComboBox.DataSource = context.Пользователи;
                MessageBox.Show(AuthenticationLocalization.RegistrationCompleted);
                UserLogin = user.Логин;
                UserType = UserTypes.User;
                DialogResult = DialogResult.OK;
            }  
        }

		private void HelpButton_Click_OnRegistration(object sender, EventArgs e)
		{
			MessageBox.Show(AuthenticationLocalization.RegistrationHelpMessage,
                                AuthenticationLocalization.RegistrationHelpCaption);
		}

		private void ChangeModeButton_Click_OnRegistration(object sender, EventArgs e)
		{
			SetAuthenticationGui();
			SetAuthenticationEventHandlers();
			ResetUserInput();
		}

		private void SetRegistrationGui()
		{
            ChangeLoginLayout(usersComboBox, loginTextBox);
            guestPanel.Visible = false;
			SetControlText(headlineLabel,AuthenticationLocalization.RegistrationHeadlineText);
			SetControlText(finishButton,AuthenticationLocalization.RegistrationFinishButtonText);
			SetControlText(helpButton,AuthenticationLocalization.RegistrationHelpButtonText);
			SetControlText(questionLabel,AuthenticationLocalization.RegistrationQuestionLabelText);
			SetControlText(changeModeButton,AuthenticationLocalization.RegistrationChangeModeButtonText);
		}

		private void SetRegistrationEventHandlers()
		{
			ChangeTextBoxTextChangedEventHandler(passwordTextBox, PasswordTextBox_TextChanged_OnAuthentication, PasswordTextBox_TextChanged_OnRegistration);
			ChangeButtonClickEventHandler(finishButton, FinishButton_Click_OnAuthentication, FinishButton_Click_OnRegistration);
			ChangeButtonClickEventHandler(helpButton, HelpButton_Click_OnAuthentication, HelpButton_Click_OnRegistration);
			ChangeButtonClickEventHandler(changeModeButton, ChangeModeButton_Click_OnAuthentication, ChangeModeButton_Click_OnRegistration);
		}
	}
}