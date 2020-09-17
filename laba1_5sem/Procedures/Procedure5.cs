﻿using System;
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
    public partial class Procedure5 : Form
    {
        private InputName inputName = new InputName();
        private Procedure procedure = new Procedure();
        public Procedure5()
        {
            InitializeComponent();
            OnComboBox();
        }

        private void OnComboBox()
        {
            List<string> names = inputName.NameP();
            for (int i = 0; i < names.Count; i++)
            {
                listBox1.Items.Add(names[i]);
            }
            listBox1.SelectedIndex = 0;
        }

        private void OnDataGrid()
        {
            dataGridView1.Rows.Clear();
            var reader = procedure.Procedure_5(listBox1.SelectedItem.ToString());
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString());
            }
            procedure.close_reader();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OnDataGrid();
        }
    }
}