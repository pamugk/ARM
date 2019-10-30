using ARM.LinguisticDBModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace ARM.MainPart
{
    public partial class ArmForm
    {
        private void langsDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = langsDGV.Rows[e.RowIndex];
            if (!langsDGV.IsCurrentRowDirty) return;
            var langNameVal = row.Cells[LangNameColumn.Name].Value as string;
            e.Cancel = langNameVal == null || langNameVal.Replace(" ", "") == "" || langNameVal.Length > 50;
            if (e.Cancel)
            {
                row.Cells[LangNameColumn.Name].ErrorText = "Введено некорректное название языка";
                return;
            }
            var langFamId = row.Cells[LangsFamColumn.Name].Value as int?;
            e.Cancel = !langFamId.HasValue || langFamId.Value == 0;
            if (e.Cancel)
            {
                row.Cells[LangsFamColumn.Name].ErrorText = "Должна быть выбрана языковая семья";
                return;
            }
            e.Cancel = (from DataGridViewRow checkedRow
                            in langsDGV.Rows
                        where checkedRow.Tag != null
                        select checkedRow.Tag as Языки)
                    .Any(checkedL => (!(row.Cells[LangIDColumn.Name].Value as int?).HasValue || checkedL.ID != ((int?) row.Cells[LangIDColumn.Name].Value).Value) 
                                            && checkedL.Название == langNameVal 
                                            && checkedL.ID_языковой_семьи == langFamId.Value);
            if (e.Cancel)
            {
                row.ErrorText = "Запись совпадает с уже существующей";
                return;
            }
            row.ErrorText = "";
            using (var context = new LinguisticModel())
            {
                var language = row.Tag as Языки;
                var isInsert = language == null;
                if (isInsert)
                    language = new Языки();
                else context.Языки.Attach(language);
                language.Название = langNameVal;
                language.ID_языковой_семьи = langFamId.Value;
                if (isInsert)
                    context.Языки.Add(language);
                context.SaveChanges();
                row.Cells[LangIDColumn.Name].Value = language.ID;
                row.Tag = language;
            }
            foreach (DataGridViewCell cell in row.Cells)
                cell.ErrorText = "";
        }

        private void langsDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (langsDGV.Rows[e.RowIndex].IsNewRow) return;
            langsDGV[e.ColumnIndex, e.RowIndex].ErrorText = "Значение изменено и пока не сохранено.";
        }

        private void langsDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var tag = e.Row.Tag as Языки;
            if (tag == null)
                return;
            using (var context = new LinguisticModel())
            {
                context.Языки.Attach(tag);
                context.Языки.Remove(tag);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    e.Cancel = true;
                    MessageBox.Show(MainLocalization.ErrorOnDelete, MainLocalization.ErrorOnDeleteHeader);
                }
            }
        }

        private void langsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LangIDColumn.Visible = false;
            foreach (DataGridViewRow row in langsDGV.Rows)
            {
                if (row.Tag != null)
                    continue;
                var id = row.Cells[LangIDColumn.Name].Value as int?;
                if (!id.HasValue || id.Value == 0)
                    continue;
                using (var context = new LinguisticModel())
                    row.Tag = context.Языки.Find(id.Value);
            }
        }
    }
}