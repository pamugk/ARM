using ARM.Security;
using ARM.UsersDBModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ARM.Management
{
    public partial class ManagementForm
    {
        private void usersDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = usersDGV.Rows[e.RowIndex];
            using (var context = new UsersModel())
            {
                var id = row.Cells[UserIDColumn.Name].Value as int?;
                var tag = row.Tag as Пользователи;
                var login = row.Cells[LoginColumn.Name].Value as string;
                e.Cancel = login == null || login.Replace(" ", "") == "" || login.Length > 50;
                if (e.Cancel)
                {
                    row.Cells[LoginColumn.Name].ErrorText = ManagementLocalization.IncorrectLoginError;
                    return;
                }
                e.Cancel = context.Пользователи.Any(user => user.ID != id.Value && user.Логин == login);
                if (e.Cancel)
                {
                    row.ErrorText = ManagementLocalization.LoginExistsError;
                    return;
                }
                var isInsert = tag == null;
                if (isInsert)
                {
                    tag = new Пользователи();
                    using (var passwordManager = new PasswordManagerForm(false))
                    {
                        if (passwordManager.ShowDialog() == DialogResult.OK)
                        {
                            tag.Соль = PasswordSecurity.GenerateSalt();
                            tag.Хэш_пароля = PasswordSecurity.GenerateHash(passwordManager.Password, tag.Соль);
                        }
                    }
                }
                else context.Пользователи.Attach(tag);
                if (tag.Логин == AdminLogin)
                {
                    AdminLogin = login;
                    userLoginLabel.Text = userLoginLabel.Tag as string + AdminLogin;
                }
                tag.Логин = login;
                tag.Администратор = (bool)row.Cells[IsAdminColumn.Name].Value;
                tag.Дата_регистрации = ((DateTime)row.Cells[RegDateColumn.Name].Value).Date;
                row.Tag = tag;
                if (isInsert)
                    context.Пользователи.Add(tag);
                context.SaveChanges();
            }
            row.ErrorText = "";
            foreach (DataGridViewCell cell in row.Cells)
                cell.ErrorText = "";
        }

        private void usersDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (usersDGV.Rows[e.RowIndex].IsNewRow) return;
            usersDGV[e.ColumnIndex, e.RowIndex].ErrorText = ManagementLocalization.ValueChangedText;
        }

        private void usersDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using (var context = new UsersModel())
            {
                var user = e.Row.Tag as Пользователи;
                if (user.Логин == AdminLogin)
                {
                    MessageBox.Show(ManagementLocalization.ErrorOnDelete, ManagementLocalization.ErrorOnDeleteHeader);
                    e.Cancel = true;
                    return;
                }
                context.Пользователи.Attach(user);
                context.Пользователи.Remove(user);
                context.SaveChanges();
            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            var row = usersDGV.SelectedRows[0];
            var id = row.Cells[UserIDColumn.Name].Value as int?;
            if (!id.HasValue || id.Value == 0)
                return;
            using (var passwordManager = new PasswordManagerForm(true))
            {
                if (passwordManager.ShowDialog(this) != DialogResult.OK) return;
                using (var context = new UsersModel())
                {
                    var tag = row.Tag as Пользователи;
                    context.Пользователи.Attach(tag);
                    tag.Соль = PasswordSecurity.GenerateSalt();
                    tag.Хэш_пароля = PasswordSecurity.GenerateHash(passwordManager.Password, tag.Соль);
                    context.SaveChanges();
                    row.Cells[HashColumn.Name].Value = tag.Хэш_пароля;
                    row.Cells[SaltColumn.Name].Value = tag.Соль;
                    row.Tag = tag;
                }
            }
        }

        private void usersDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in usersDGV.Rows)
            {
                if (row.Tag != null)
                    continue;
                var id = row.Cells[UserIDColumn.Name].Value as int?;
                if (!id.HasValue || id.Value == 0)
                    continue;
                using (var context = new UsersModel())
                {
                    if (row.Cells[LoginColumn.Name].Value as string == AdminLogin)
                        row.Cells[IsAdminColumn.Name].ReadOnly = true;
                    row.Tag = context.Пользователи.Find(id);
                }
            }
        }
    }
}