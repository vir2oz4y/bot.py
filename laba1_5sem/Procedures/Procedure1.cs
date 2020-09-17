using System;
using System.Windows.Forms;

namespace laba1_5sem
{
    public partial class Procedure1 : Form
    {
        public Procedure1()
        {
            InitializeComponent();
        }

        private void Procedure1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postavkiDataSet.full_itog". При необходимости она может быть перемещена или удалена.
            this.full_itogTableAdapter.Fill(this.postavkiDataSet.full_itog);

        }
    }
}
