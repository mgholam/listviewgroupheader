using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listviewgrp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listView1.BackColor = Color.FromArgb(32, 32, 32);
            listView1.ForeColor = Color.Silver;

            var today = new ListViewGroup("Today");
            today.HeaderAlignment = HorizontalAlignment.Left;

            listView1.Groups.Add(today);
            listView1.ShowGroups = true;
            listView1.View = View.LargeIcon;

            var list = new List<string>
            {
                "aaaaaaaaaaaaaaaaaaa",
                "bbbbbbbbbbbbbbbbbbbbb",
                "ccccccccccccccccccccc"
            };

            foreach (var i in list)
            {
                var lvi = new ListViewItem();
                lvi.Name = "Title";
                lvi.Text = i;

                var grp = today;
                lvi.Group = grp;
                listView1.Items.Add(lvi);
            }
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }
    }
}
