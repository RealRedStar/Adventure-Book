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

namespace Adventure_book
{
    public partial class AddDialog : Form
    {
        public AddDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TaskName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt";
            int ID = File.ReadLines(path).Count() + 1;
            string line = ID + ";" + InTaskName.Text + ";" + InTaskDescription.Text + ";" + dateTimePicker1.Value + ";";
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine(line);
            }
            

        }

        private void InTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InTaskDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
