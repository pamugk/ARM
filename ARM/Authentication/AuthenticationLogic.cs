using System;
using System.Windows.Forms;
using ARM.Security;
using ARM.UsersDBModel;

namespace ARM.Authentication
{
    public partial class AuthenticationForm
	{
        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedIndex == -1)
            {
                ForbidFinish();
                return;
            }
            if (passwordTextBox.Text != "")
                AllowFinish();
        }

		private void PasswordTextBox_TextChanged_OnAuthentication(object sender, EventArgs e)
		{
			if (passwordTextBox.Text == "")
			{
				ForbidFinish();
				return;
			}
			if (usersComboBox.SelectedIndex != -1)
				AllowFinish();
		}

		private void FinishButton_Click_OnAuthentication(object sender, EventArgs e)
		{
		    if (guestCheckBox.Checked)
            {
                MessageBox.Show(AuthenticationLocalization.GuestMessage, AuthenticationLocalization.GuestMessageHeader);
                UserLogin = AuthenticationLocalization.GuestLogin;
                UserType = UserTypes.Guest;
                DialogResult = DialogResult.OK;
                return;
            }
		    using (var context = new UsersModel())
		    {
		        var user = usersComboBox.SelectedItem as Пользователи;
		        if (user == null)
		            MessageBox.Show($@"{AuthenticationLocalization.AuthenticationError}{AuthenticationLocalization.AuthenticationLoginError}");
		        context.Пользователи.Attach(user);
		        UserLogin = user.Логин;
		        UserType = user.Администратор ? UserTypes.Admin : UserTypes.User;
		        var generatedHash = PasswordSecurity.GenerateHash(passwordTextBox.Text, user.Соль);
		        if (!generatedHash.Equals(user.Хэш_пароля))
		        {
		            MessageBox.Show($@"{AuthenticationLocalization.AuthenticationError}
                                       {AuthenticationLocalization.AuthenticationPasswordError}");
                    return;
		        }
		        MessageBox.Show(AuthenticationLocalization.AuthenticationCompleted);
		        DialogResult = DialogResult.OK;
		    }
		}

		private void HelpButton_Click_OnAuthentication(object sender, EventArgs e)
		{
			MessageBox.Show($"{AuthenticationLocalization.AuthenticationHelpMessage1}{AuthenticationLocalization.AuthenticationHelpMessage2}{AuthenticationLocalization.AuthenticationHelpMessage3}",
                                AuthenticationLocalization.AuthenticationHelpCaption);
		}

		private void ChangeModeButton_Click_OnAuthentication(object sender, EventArgs e)
		{
			SetRegistrationGui();
			SetRegistrationEventHandlers();
			ResetUserInput();
		}

		private void SetAuthenticationGui()
        {
            guestPanel.Visible = true;
            ChangeLoginLayout(loginTextBox, usersComboBox);
			SetControlText(headlineLabel,AuthenticationLocalization.AuthenticationHeadlineText);
			SetControlText(finishButton,AuthenticationLocalization.AuthenticationFinishButtonText);
			SetControlText(helpButton,AuthenticationLocalization.AuthenticationHelpButtonText);
			SetControlText(questionLabel,AuthenticationLocalization.AuthenticationQuestionLabelText);
			SetControlText(changeModeButton,AuthenticationLocalization.AuthenticationChangeModeButtonText);
		}

		private void SetAuthenticationEventHandlers()
		{
			ChangeTextBoxTextChangedEventHandler(passwordTextBox, PasswordTextBox_TextChanged_OnRegistration, PasswordTextBox_TextChanged_OnAuthentication);
			ChangeButtonClickEventHandler(finishButton, FinishButton_Click_OnRegistration, FinishButton_Click_OnAuthentication);
			ChangeButtonClickEventHandler(helpButton, HelpButton_Click_OnRegistration, HelpButton_Click_OnAuthentication);
			ChangeButtonClickEventHandler(changeModeButton, ChangeModeButton_Click_OnRegistration, ChangeModeButton_Click_OnAuthentication);
		}
	}
}