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
        public Point mouseLocation;
        public AddDialog(Boolean lightMode)
        {
            InitializeComponent();
            if (lightMode)
            {
                button1.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button1.ForeColor = ColorTranslator.FromHtml("#000000");
                button2.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button2.ForeColor = ColorTranslator.FromHtml("#000000");
                button3.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button3.ForeColor = ColorTranslator.FromHtml("#000000");
                button4.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button4.ForeColor = ColorTranslator.FromHtml("#000000");
                BackColor = ColorTranslator.FromHtml("#FFFFFF");
                TaskName.ForeColor = ColorTranslator.FromHtml("#000000");
                TaskName.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                Title.ForeColor = ColorTranslator.FromHtml("#000000");
                Title.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                TaskDeadline.ForeColor = ColorTranslator.FromHtml("#000000");
                TaskDeadline.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                TaskDescription.ForeColor = ColorTranslator.FromHtml("#000000");
                TaskDescription.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                TitleBar.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                panel1.BackColor = ColorTranslator.FromHtml("#E8E8E8");
            }
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
            Form1 form = new Form1();
            this.Close();

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
