using System;
using System.Linq;
using System.Windows.Forms;
using ARM.LinguisticDBModel;

namespace ARM.StandardQueries
{
    public partial class RecentEthnoOrgsForm : Form
    {
        public RecentEthnoOrgsForm()
        {
            InitializeComponent();
        }

        private void RecentEthnoOrgsForm_Load(object sender, EventArgs e)
        {
            using (var context = new LinguisticModel())
                этнографическиеорганизацииBindingSource.DataSource = context.Этнографические_организации.ToList()
                    .Where(ethno => ethno.Дата_основания.Year.Equals(DateTime.Now.Year));
            ethnoDGV.ReadOnly = true;
        }
    }
}