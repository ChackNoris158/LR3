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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Books1DataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.dB_Books1DataSet.Authors);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
