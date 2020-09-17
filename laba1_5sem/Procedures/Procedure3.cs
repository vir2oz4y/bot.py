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
    public partial class Procedure3 : Form
    {
        private InputName inputName = new InputName();
        private Procedure procedure = new Procedure();
        public Procedure3()
        {
            InitializeComponent();
            OnComboBox();
        }

        private void OnComboBox()
        {
            List<string> names = inputName.NameT();
            for (int i = 0; i < names.Count; i++)
            {
                listBox1.Items.Add(names[i]);
            }
            listBox1.SelectedIndex = 0;
        }

        private void OnDataGrid()
        {
            dataGridView1.Rows.Clear();
            var reader = procedure.Procedure_3(listBox1.SelectedItem.ToString(), dateTimePicker1.Value.ToString(), textBox3.Text);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
            procedure.close_reader();
        }

        private void Check_Int()
        {
            int a;
            if (int.TryParse(textBox3.Text, out a))
            {
                OnDataGrid();
            }
            else
            {
                MessageBox.Show("Срок годности не число!!!");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Check_Int();
        }
    }
}
