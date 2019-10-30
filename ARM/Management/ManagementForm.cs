using System;
using System.Linq;
using System.Windows.Forms;
using ARM.UsersDBModel;

namespace ARM.Management
{
    public partial class ManagementForm : Form
    {
        public string AdminLogin { get; private set; }

        public ManagementForm(string userLogin)
        {
            AdminLogin = userLogin;
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            userLoginLabel.Tag = userLoginLabel.Text;
            userLoginLabel.Text += AdminLogin;
            using (var context = new UsersModel())
                пользователиBindingSource.DataSource = context.Пользователи.ToList();
        }
    }
}