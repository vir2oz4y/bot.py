using System;
using System.Windows.Forms;

namespace laba1_5sem
{
    public partial class Procedure7 : Form
    {
        private Procedure procedure = new Procedure();
        public Procedure7()
        {
            InitializeComponent();
            
        }

        public void OnDataGrid()
        {
            dataGridView1.Rows.Clear();
            
            var reader = procedure.Procedure_7(dateTimePicker1.Value.ToString());
            int count = reader.FieldCount;
            DataGridViewColumn column;
            for (int i = 0; i < count; i++)
            {
                column = new DataGridViewColumn()
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    HeaderText = reader.GetName(i)
                };
                dataGridView1.Columns.Add(column);
            }

            int index = 0;
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                
                
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Rows[index].Cells[i].Value=reader[i].ToString() ;
                }
                index++;
            }
            procedure.close_reader();
        }

        private void Procedure7_Load(object sender, EventArgs e)
        {

            OnDataGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OnDataGrid();
        }
    }
}
