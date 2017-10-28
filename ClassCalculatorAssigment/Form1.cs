using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculatorAssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Not Allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else

            comboBox1.Items.Add(textBox1.Text);
            //list box k lye
            listBox1.Items.Add(textBox1.Text);
            //jsy combobox k lye jha jha coding ki ha wse listbox k lye hoge
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch == 8 && ch == 46)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Items are\t" + comboBox1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);

          //  listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;

            listBox1.Sorted = true;
        }
    }
}
