using System.Windows.Forms;

namespace ARM.Management
{
    public partial class PasswordManagerForm : Form
    {
        public string Password { get; private set; }

        public PasswordManagerForm(bool isChanging)
        {
            InitializeComponent();
            cancelButton.Enabled = false;
            Text = isChanging ? "Изменение пароля" : "Задание пароля";
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            Password = passwordTextBox.Text;
        }
    }
}
