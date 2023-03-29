using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        OpenFileDialog fd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            fd.Filter = "txt file(*.txt)|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Form2 f = new Form2();
                f.FileName = fd.FileName;
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fd.Filter = "excel file(*.xls)|*.xls";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string s = fd.FileName;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
