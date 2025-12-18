using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            if (checkBox1.Checked)
            {
                s = textBox1.Text + "|" + textBox2.Text + "|" + dateTimePicker1.Text + "|" + comboBox1.Text + "|" + numericUpDown1.Value + "|" + "dostupna";
            }
            else
            {
                s = textBox1.Text + "|" + textBox2.Text + "|" + dateTimePicker1.Text + "|" + comboBox1.Text + "|" + numericUpDown1.Value + "|" + "nedostupna";
            }
            admin.SaveBook(s);
            MessageBox.Show("Knjiga je spremljena.");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
