using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using ARM.LinguisticDBModel;
using System.Windows.Forms;

namespace ARM.MainPart
{
    public partial class ArmForm
    {
        private void ethnoOrgDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = ethnoOrgsDGV.Rows[e.RowIndex];
            if (!ethnoOrgsDGV.IsCurrentRowDirty) return;
            var ethnoNameVal = row.Cells[EthnoOrgNameColumn.Name].Value as string;
            e.Cancel = ethnoNameVal == null || ethnoNameVal.Replace(" ", "") == "" || ethnoNameVal.Length > 50;
            if (e.Cancel)
            {
                row.Cells[EthnoOrgNameColumn.Name].ErrorText = "Введено некорректное название этнографической организации";
                return;
            }
            var hqVal = row.Cells[EthnoOrgHQColumn.Name].Value as string;
            e.Cancel = hqVal == null || hqVal.Replace(" ", "") == "" || hqVal.Length > 160;
            if (e.Cancel)
            {
                row.Cells[EthnoOrgHQColumn.Name].ErrorText = "Введено некорректное местоположение штаб-квартиры";
                return;
            }
            var date = ((DateTime) row.Cells[EthnoOrgDateColumn.Name].Value).Date;
            using (var context = new LinguisticModel())
            {
                e.Cancel = context.Этнографические_организации.Any(ethno =>
                    (!(row.Cells[EthnoOrgIDColumn.Name].Value as int?).HasValue || ethno.ID != ((int?)row.Cells[EthnoOrgIDColumn.Name].Value).Value) 
                    && ethno.Название == ethnoNameVal && ethno.Штаб_квартира == hqVal 
                    && ethno.Дата_основания.Equals(date));
                if (e.Cancel)
                {
                    row.ErrorText = "Запись совпадает с уже существующей";
                    return;
                }
                row.ErrorText = "";
                var ethnoOrg = row.Tag as Этнографические_организации;
                var isInsert = ethnoOrg == null;
                if (isInsert)
                    ethnoOrg = new Этнографические_организации();
                else context.Этнографические_организации.Attach(ethnoOrg);
                ethnoOrg.Название = ethnoNameVal;
                ethnoOrg.Штаб_квартира = hqVal;
                ethnoOrg.Дата_основания = date;
                if (isInsert)
                    context.Этнографические_организации.Add(ethnoOrg);
                context.SaveChanges();
                row.Cells[EthnoOrgIDColumn.Name].Value = ethnoOrg.ID;
                row.Tag = ethnoOrg;
            }
            foreach (DataGridViewCell cell in row.Cells)
                cell.ErrorText = "";
        }

        private void ethnoOrgDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (ethnoOrgsDGV.Rows[e.RowIndex].IsNewRow) return;
            ethnoOrgsDGV[e.ColumnIndex, e.RowIndex].ErrorText = "Значение изменено и пока не сохранено.";
        }

        private void ethnoOrgDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var tag = e.Row.Tag as Этнографические_организации;
            if (tag == null)
                return;
            using (var context = new LinguisticModel())
            {
                context.Этнографические_организации.Attach(tag);
                context.Этнографические_организации.Remove(tag);
                try
                {
                    context.SaveChanges();
                    foreach (DataGridViewRow row in langsCountDGV.SelectedRows)
                        langsCountDGV.Rows.RemoveAt(row.Index);
                }
                catch (DbUpdateException)
                {
                    e.Cancel = true;
                    MessageBox.Show(MainLocalization.ErrorOnDelete, MainLocalization.ErrorOnDeleteHeader);
                }
            }
        }

        private void ethnoOrgDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in ethnoOrgsDGV.Rows)
            {
                if (row.Tag != null)
                    continue;
                var id = row.Cells[EthnoOrgIDColumn.Name].Value as int?;
                if (!id.HasValue || id.Value == 0)
                    continue;
                using (var context = new LinguisticModel())
                    row.Tag = context.Этнографические_организации.Find(id.Value);
            }
        }
    }
}