using playAround.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace playAround
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Item1");
            checkedListBox1.Items.Add("Item2");
            checkedListBox1.Items.Add("Item3");
            checkedListBox1.Items.Add("Item4");
            checkedListBox1.Items.Add("Item5");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i,true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 2)
            {
                checkedListBox1.Items.RemoveAt(2);

            }
        }
    }
}
