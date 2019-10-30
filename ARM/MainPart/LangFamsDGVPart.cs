using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using ARM.LinguisticDBModel;

namespace ARM.MainPart
{
    public partial class ArmForm
    {
        private void langFamsDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = langFamsDGV.Rows[e.RowIndex];
            if (!langFamsDGV.IsCurrentRowDirty) return;
            var langFamNameVal = row.Cells[LangFamNameColumn.Name].Value as string;
            e.Cancel = langFamNameVal == null || langFamNameVal.Replace(" ", "") == "" || langFamNameVal.Length > 50;
            if (e.Cancel)
            {
                row.Cells[LangFamNameColumn.Name].ErrorText = "Введено некорректное название языковой семьи";
                return;
            }
            var langFamMacroId = row.Cells[LangFamMacroColumn.Name].Value as int?;
            e.Cancel = (from DataGridViewRow checkedRow
                            in langFamsDGV.Rows
                        where checkedRow.Tag != null
                        select checkedRow.Tag as Языковые_семьи)
                    .Any(checkedL => (!(row.Cells[LangFamIDColumn.Name].Value as int?).HasValue || checkedL.ID != ((int?)row.Cells[LangFamIDColumn.Name].Value).Value) 
                                     && checkedL.Название == langFamNameVal 
                                     && checkedL.ID_языковой_макросемьи == langFamMacroId);
            if (e.Cancel)
            {
                row.ErrorText = "Запись совпадает с уже существующей.";
                return;
            }
            row.ErrorText = "";
            using (var context = new LinguisticModel())
            {
                var langFam = row.Tag as Языковые_семьи;
                var isInsert = langFam == null;
                if (isInsert)
                    langFam = new Языковые_семьи();
                else context.Языковые_семьи.Attach(langFam);
                langFam.Название = langFamNameVal;
                langFam.ID_языковой_макросемьи = langFamMacroId;
                if (isInsert)
                    context.Языковые_семьи.Add(langFam);
                context.SaveChanges();
                row.Cells[LangFamIDColumn.Name].Value = langFam.ID;
                row.Tag = langFam;
            }
            foreach (DataGridViewCell cell in row.Cells)
                cell.ErrorText = "";
        }

        private void langFamsDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (langFamsDGV.Rows[e.RowIndex].IsNewRow) return;
            langFamsDGV[e.ColumnIndex, e.RowIndex].ErrorText = "Значение изменено и пока не сохранено.";
        }

        private void langFamsDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var tag = e.Row.Tag as Языковые_семьи;
            if (tag == null)
                return;
            using (var context = new LinguisticModel())
            {
                context.Языковые_семьи.Attach(tag);
                context.Языковые_семьи.Remove(tag);
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

        private void langFamsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LangFamIDColumn.Visible = false;
            foreach (DataGridViewRow row in langFamsDGV.Rows)
            {
                if (row.Tag != null)
                    continue;
                var id = row.Cells[LangFamIDColumn.Name].Value as int?;
                if (!id.HasValue || id.Value == 0)
                    continue;
                using (var context = new LinguisticModel())
                    row.Tag = context.Языковые_семьи.Find(id.Value);
            }
        }
    }
}