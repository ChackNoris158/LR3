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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Books1DataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.dB_Books1DataSet.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Books1DataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.dB_Books1DataSet.Authors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Books1DataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dB_Books1DataSet.Books);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.booksTableAdapter.Update(this.dB_Books1DataSet.Books);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Publish = " +
            dataGridView1[4, bb].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Title_book = " +
            dataGridView1[1, bb].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Author = " +
            dataGridView1[0, bb].Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Pages = " +
            dataGridView1[3, bb].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }
    }
}
