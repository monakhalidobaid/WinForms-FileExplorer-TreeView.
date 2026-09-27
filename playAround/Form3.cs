using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playAround
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("mm-dd-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd-MMMM-yyyy") + Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy"));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToString("dd-MM-yyyy"));

        }
        int count;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            label2.Text = count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
