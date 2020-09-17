using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_5sem
{
    public partial class Procedure8 : Form
    {
        private Procedure procedure = new Procedure();
        public Procedure8()
        {
            InitializeComponent();
        }
        public void OnDataGrid()
        {
            dataGridView1.Rows.Clear();

            var reader = procedure.Procedure_8(dateTimePicker1.Value.ToString());
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
                    dataGridView1.Rows[index].Cells[i].Value = reader[i].ToString();
                }
                index++;
            }
            procedure.close_reader();
        }

        private void Procedure8_Load(object sender, EventArgs e)
        {
            OnDataGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OnDataGrid();
        }
    }
}
