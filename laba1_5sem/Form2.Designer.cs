﻿namespace laba1_5sem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(475, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Содержимое таблицы Итог с заменой кода товара на название товара и кода поставщик" +
    "а";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(475, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Для заданного наименования поставщика: наименование товара, дату поставки, дату\r\n" +
    "производства, срок годности, суммарный объем поставок и количество поставок этог" +
    "о\r\nтовара поставщиком в эту дату;";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(475, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = resources.GetString("button3.Text");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(475, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Для каждого наименования поставщика суммарные объемы его поставок товаров в\r\nтеку" +
    "щем месяце, текущем квартале и в текущем году;";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(475, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Для заданного поставщика названия других поставщиков, которые поставляли хотя бы\r" +
    "\nодин товар, что и заданный поставщик с одинаковой датой производства.";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(475, 54);
            this.button6.TabIndex = 5;
            this.button6.Text = "Для заданного поставщика названия других поставщиков, которые поставляли только т" +
    "е\r\nже товары, что и заданный поставщик, но с разные сроками годности;";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(475, 39);
            this.button7.TabIndex = 6;
            this.button7.Text = "по суммарному объему поставок в заданном году и месяце с не просроченным\r\nсроком " +
    "годности;";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 384);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(475, 39);
            this.button8.TabIndex = 7;
            this.button8.Text = "по суммарному объему благотворительных поставок в заданном году и месяце.";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 484);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(475, 39);
            this.button9.TabIndex = 8;
            this.button9.Text = "Выход";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 557);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}