using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace viewer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String Output = @"C:\Users\Computer\Desktop\OOP\ContactTracingForm\CTF\Data\" + textBoxSearch.Text+".txt";
            if (File.Exists(Output))
            {
                string readfile = File.ReadAllText(Output);
                richTextBoxinfo.Text = readfile;
            }
            else
            {
                richTextBoxinfo.Text = "Not Found";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxinfo.Text = "";
            textBoxSearch.Text = "";
        }
    }
}
