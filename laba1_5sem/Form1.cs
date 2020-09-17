using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace laba1_5sem
{
    public partial class Form1 : Form
    {
        private Data dataReader = new Data();
        private InsertData insert = new InsertData();
        private UpdateData updateData = new UpdateData();
        private DeleteData delete = new DeleteData();
        private Procedure procedure = new Procedure();
        private DataCheck dataCheck = new DataCheck();
        private InputData input = new InputData();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Товар");
            comboBox1.Items.Add("Поставщик");
            comboBox1.Items.Add("Поставки");
            comboBox1.Items.Add("Итог");
            comboBox1.SelectedIndex = 0;
            panel3.Location = panel1.Location;
            panel4.Location = panel1.Location;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void completion_dataGrid(int Index)
        {
            if (Index == 0)
            {
                dataGridView1.DataSource = input.Input_tovar();
                dataGridView1.Width = 260;
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;

                panel1.Enabled = true;
                panel3.Enabled = false;
                panel4.Enabled = false;

            }
            if (Index == 1)
            {
                dataGridView1.DataSource = input.Input_postavshik();
                dataGridView1.Width = 340;
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = false;

                panel1.Enabled = false;
                panel3.Enabled = true;
                panel4.Enabled = false;
            }
            if (Index == 2)
            {
                dataGridView1.DataSource = input.Input_post();
                dataGridView1.Width = 840;
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = true;

                panel1.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = true;
            }
            if (Index == 3)
            {
                dataGridView1.DataSource = input.Input_itog();
                dataGridView1.Width = 840;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;

                panel1.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
            }

        }

        private void update()
        {
            completion_dataGrid(comboBox1.SelectedIndex);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;

            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBox4.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox5.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBox7.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox8.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                if (dataGridView1.Rows[index].Cells[3].Value.ToString() == "")
                {
                    checkBox1.Checked = true;
                    
                }
                else
                {
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[index].Cells[3].Value.ToString());

                }


                if (dataGridView1.Rows[index].Cells[4].Value.ToString() == "")
                {
                    checkBox2.Checked = true;
                    textBox10.Text = "";

                }
                else
                {
                    textBox10.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    checkBox2.Checked = false;
                }

                if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "")
                {
                    checkBox3.Checked = true;
                    textBox11.Text = "";
                }
                else
                {
                    textBox11.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    checkBox3.Checked = false;
                }

                if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "")
                {
                    checkBox4.Checked = true;
                    textBox12.Text = "";
                }
                else
                {
                    textBox12.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    checkBox4.Checked = false;
                }

                dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[index].Cells[7].Value.ToString());

            }
        }

        private void Button1_Click(object sender, EventArgs e)// добавление
        {
            if (comboBox1.SelectedIndex==0)
            {
                if (dataCheck.TovarCheck(textBox2.Text))
                {
                    insert.insertTovar(dataCheck.TovarGet(textBox2.Text));
                    update();
                }
                else
                {
                    MessageBox.Show(dataCheck.Errors);
                    dataCheck.Errors = "";
                }
                
            }

            if (comboBox1.SelectedIndex==1)
            {
                if (dataCheck.PostavshicCheck(textBox4.Text, textBox5.Text))
                {
                    string postavshickName = dataCheck.PostavshickGet(textBox4.Text, textBox5.Text)[0];
                    string postavshickCity= dataCheck.PostavshickGet(textBox4.Text, textBox5.Text)[1];
                    insert.insertPostavshik(postavshickName,postavshickCity);
                    update();
                }
                //else
                {
                    MessageBox.Show(dataCheck.Errors);
                    dataCheck.Errors = "";
                }
                
            }

            if (comboBox1.SelectedIndex==2)
            {
                string idt = textBox7.Text;
                string idp = textBox8.Text;
                string dpr = (checkBox1.Checked == false) ? dateTimePicker1.Value.ToString() : "null";
                string sr =(checkBox2.Checked==false)?textBox10.Text:"null";
                string v =(checkBox3.Checked==false)? textBox11.Text: "null";
                string st =(checkBox4.Checked==false)? textBox12.Text: "null";
                string dp = dateTimePicker2.Value.ToString();

                if (dataCheck.PostCheck(idt, idp, dpr, sr, v, st, dp))
                {
                    insert.insertPost(idt, idp, dpr, sr, v, st, dp);
                    update();
                }
                else
                {
                    MessageBox.Show(dataCheck.Errors);
                    dataCheck.Errors = "";
                }

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = !textBox10.Enabled;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Enabled = !textBox11.Enabled;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.Enabled = !textBox12.Enabled;
        }

        private void Button2_Click(object sender, EventArgs e)//изменение
        {
            DialogResult result = MessageBox.Show(
                "Дeйствительно хотите изменить данные?",
                "ВНИМАНИЕ!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result==DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index;
                if (comboBox1.SelectedIndex == 0)
                {
                    if (dataCheck.TovarCheck(textBox2.Text))
                    {
                        updateData.updateTovar(dataGridView1.Rows[index].Cells[1].Value.ToString(), dataCheck.TovarGet(textBox2.Text));
                        update();
                    }
                    else
                    {
                        MessageBox.Show(dataCheck.Errors);
                        dataCheck.Errors = "";
                    }
                    
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (dataCheck.PostavshicCheck(textBox4.Text, textBox5.Text))
                    {
                        string postavshickName = dataCheck.PostavshickGet(textBox4.Text, textBox5.Text)[0];
                        string postavshickCity = dataCheck.PostavshickGet(textBox4.Text, textBox5.Text)[1];
                        updateData.updatePostavshik(postavshickName, postavshickCity, dataGridView1.Rows[index].Cells[0].Value.ToString());
                        update();
                    }
                    else
                    {
                        MessageBox.Show(dataCheck.Errors);
                        dataCheck.Errors = "";
                    }
                   
                }

                if (comboBox1.SelectedIndex==2)
                {
                    string idt = textBox7.Text;
                    string idp = textBox8.Text;
                    string dpr = (checkBox1.Checked == false) ? dateTimePicker1.Value.ToString() : "null";
                    string sr = (checkBox2.Checked == false) ? textBox10.Text : "null";

                    string v = (checkBox3.Checked == false) ? textBox11.Text : "null";
                    v = v.Replace('.', ',');
                    string st = (checkBox4.Checked == false) ? textBox12.Text : "null";
                    st = st.Replace('.', ',');
                    string dp = dateTimePicker2.Value.ToString();
                    string np = dataGridView1.Rows[index].Cells[0].Value.ToString();
                   
                    if (dataCheck.PostCheck(idt, idp, dpr, sr, v, st, dp))
                    {
                        updateData.updatePost(idt, idp, dpr, sr, v, st, dp, np);
                        update();
                    }
                    else
                    {
                        MessageBox.Show(dataCheck.Errors);
                        dataCheck.Errors = "";
                    }
                }

            }
          
        }

        private void Button3_Click(object sender, EventArgs e)// удаление
        {
            DialogResult result = MessageBox.Show(
               "Дeйствительно хотите удалить данные?",
               "ВНИМАНИЕ!!!",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index;
                if (comboBox1.SelectedIndex == 0)
                {
                    delete.deleteTovar(dataGridView1.Rows[index].Cells[0].Value.ToString());
                    update();
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    delete.deletePostavshik(dataGridView1.Rows[index].Cells[0].Value.ToString());
                    update();
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    delete.deletePost(dataGridView1.Rows[index].Cells[0].Value.ToString());
                    update();
                }

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            procedure.ProcedureRun("for_null");
            update();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            procedure.ProcedureRun("delete_expired");
            update();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }
    }

    
}
