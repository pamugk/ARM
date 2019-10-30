using System;
using System.Linq;
using ARM.LinguisticDBModel;
using System.Windows.Forms;

namespace ARM.MainPart
{
    public partial class ArmForm
    {
        private void langsCountDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = langsCountDGV.Rows[e.RowIndex];
            if (!langsCountDGV.IsCurrentRowDirty) return;
            var lcRecord = row.Tag as Число_носителей_языков;
            var ethnoOrgId = row.Cells[EthnoColumn.Name].Value as int?;
            var langId = row.Cells[LangColumn.Name].Value as int?;
            var dateVal = ((DateTime)row.Cells[DateColumn.Name].Value).Date;
            var isInsert = lcRecord == null;
            if (isInsert)
            {
                e.Cancel = !ethnoOrgId.HasValue;
                if (e.Cancel)
                {
                    row.Cells[EthnoColumn.Name].ErrorText = "Должна быть выбрана организация";
                    return;
                };
                e.Cancel = !langId.HasValue;
                if (e.Cancel)
                {
                    row.Cells[LangColumn.Name].ErrorText = "Должен быть выбран язык";
                    return;
                }
                e.Cancel = (from DataGridViewRow checkedRow
                            in langsCountDGV.Rows
                            where checkedRow.Tag != null
                            select checkedRow.Tag as Число_носителей_языков)
                    .Any(checkedLcRecord => checkedLcRecord.ID_организации__производившей_подсчет == ethnoOrgId &&
                                            checkedLcRecord.ID_языка == langId &&
                                            checkedLcRecord.Дата_подсчёта.Date.Equals(dateVal));
                if (e.Cancel)
                {
                    row.ErrorText = "Запись с указанными ключевыми значениями уже существует.";
                    return;
                }
                row.ErrorText = "";
            }
            var countVal = row.Cells[CountColumn.Name].Value as int?;
            e.Cancel = !countVal.HasValue || countVal < 0;
            if (e.Cancel)
            {
                row.Cells[CountColumn.Name].ErrorText = "Введено некорректное число";
                return;
            }
            using (var context = new LinguisticModel())
            {
                if (!isInsert)
                    context.Число_носителей_языков.Attach(lcRecord);
                else lcRecord = new Число_носителей_языков();
                lcRecord.Число_носителей = countVal.Value;
                if (isInsert)
                {
                    lcRecord.ID_организации__производившей_подсчет = ethnoOrgId.Value;
                    lcRecord.ID_языка = langId.Value;
                    var language = (from DataGridViewRow r in langsDGV.Rows
                                    where r.Tag != null
                                    select r.Tag as Языки)
                                    .First(lang => lang.ID == langId.Value);
                    context.Языки.Attach(language);
                    language.Число_носителей_языков.Add(lcRecord);
                    lcRecord.Языки = language;
                    row.Cells[LangsColumn.Name].Value = lcRecord.Языки;
                    lcRecord.Дата_подсчёта = dateVal;
                    row.Cells[EthnoColumn.Name].ReadOnly = true;
                    row.Cells[LangColumn.Name].ReadOnly = true;
                    row.Cells[DateColumn.Name].ReadOnly = true;
                    context.Число_носителей_языков.Add(lcRecord); 
                }
                context.SaveChanges();
                row.Tag = lcRecord;
            }
            foreach (DataGridViewCell cell in row.Cells)
                cell.ErrorText = "";
        }

        private void langsCountDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (langsCountDGV.Rows[e.RowIndex].IsNewRow) return;
            langsCountDGV[e.ColumnIndex, e.RowIndex].ErrorText = "Значение изменено и пока не сохранено.";
        }

        private void langsCountDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var tag = e.Row.Tag as Число_носителей_языков;
            if (tag == null)
                return;
            using (var context = new LinguisticModel())
            {
                context.Число_носителей_языков.Attach(tag);
                context.Число_носителей_языков.Remove(tag);
                context.SaveChanges();
            }
        }

        private void langsCountDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in langsCountDGV.Rows)
            {
                if (row.Tag != null)
                    continue;
                if (row.Cells[LangsColumn.Name].Value == null)
                    continue;
                var langId = row.Cells[LangColumn.Name].Value;
                row.Cells[EthnoColumn.Name].ReadOnly = true;
                var date = row.Cells[DateColumn.Name].Value;
                row.Cells[LangColumn.Name].ReadOnly = true;
                var ethnoId = row.Cells[EthnoColumn.Name].Value;
                row.Cells[DateColumn.Name].ReadOnly = true;
                using (var context = new LinguisticModel())
                    row.Tag = context.Число_носителей_языков.Find(langId, date, ethnoId);
            }
        }
    }
}