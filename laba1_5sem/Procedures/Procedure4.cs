using System;
using System.Windows.Forms;

namespace laba1_5sem
{
    public partial class Procedure4 : Form
    {
        public Procedure4()
        {
            InitializeComponent();
        }

        private void Procedure4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postavkiDataSet.procedure_4". При необходимости она может быть перемещена или удалена.
            this.procedure_4TableAdapter.Fill(this.postavkiDataSet.procedure_4);

        }
    }
}
