using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            Hide();
            a.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            Hide();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            Hide();
            a.Show();

        }
    }
}
