using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string FileName { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            list_of_employees elist = new list_of_employees();
            char del = t1.Text[0]; //the delimiter from user
            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                string[] emol = s.Split(del);
                employee ee = new employee();
                ee.name = emol[0];
                ee.id = emol[1];
                ee.salary = emol[2];
                ee.age =   emol[3];
                ee.gender = emol[4];
                ee.depart = emol[5];
                elist.emplist.Add(ee);
            }
            this.Hide();
        }
    }
}
