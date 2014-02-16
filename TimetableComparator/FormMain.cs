using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableComparator
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt_chooseFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
                tb_timetable1.Text = openFileDialog1.FileName;
        }

        private void bt_chooseFile2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
                tb_timetable2.Text = openFileDialog1.FileName;
        }

        private void bt_compare_Click(object sender, EventArgs e)
        {
            TimetableComparator tc = new TimetableComparator(tb_timetable1.Text,tb_timetable2.Text);
            tc.Compare(nud_numberWeek.Value.ToString(), nud_subgroup1.Value.ToString(), nud_subgroup2.Value.ToString());
        }
    }
}
