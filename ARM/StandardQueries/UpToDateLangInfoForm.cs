using System.Collections.Generic;
using System.Linq;
using ARM.LinguisticDBModel;
using System.Windows.Forms;

namespace ARM.StandardQueries
{
    public partial class UpToDateLangInfoForm : Form
    {
        public UpToDateLangInfoForm()
        {
            InitializeComponent();
        }

        private void UpToDateLangInfoForm_Load(object sender, System.EventArgs e)
        {
            using (var context = new LinguisticModel())
            {
                foreach (var lang in context.Языки.ToList().OrderBy(lang=>lang.Название))
                {
                    if (lang.Число_носителей_языков.Count == 0)
                    {
                        langsInfoDGV.Rows.Add(lang.Языковые_семьи.Название, lang.Название, "Нет данных", "Нет данных", "Нет данных");
                        continue;
                    }
                    var maxLCRs = new List<Число_носителей_языков>();
                    foreach (var lcr in lang.Число_носителей_языков)
                    {
                        if (maxLCRs.Count == 0)
                        {
                            maxLCRs.Add(lcr);
                            continue;
                        }
                        if (maxLCRs[0].Дата_подсчёта.Equals(lcr.Дата_подсчёта))
                            maxLCRs.Add(lcr);
                        else
                            if (maxLCRs[0].Дата_подсчёта < lcr.Дата_подсчёта)
                            {
                                maxLCRs.Clear();
                                maxLCRs.Add(lcr);
                            }
                    }
                    foreach (var lcr in maxLCRs.OrderBy(lcr=>lcr.Число_носителей))
                        langsInfoDGV.Rows.Add(lang.Языковые_семьи.Название, 
                                                lang.Название, 
                                                lcr.Дата_подсчёта.ToShortDateString(), 
                                                lcr.Число_носителей, 
                                                context.Этнографические_организации.Find(lcr.ID_организации__производившей_подсчет).Название);
                }
            }
            langsInfoDGV.AllowUserToAddRows = false;
            langsInfoDGV.ReadOnly = true;
        }
    }
}