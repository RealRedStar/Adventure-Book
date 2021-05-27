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
        int mouseX = 0;
        int mouseY = 0;
        int mouseinX;
        int mouseinY; 
        Boolean mouseDown;
        public AddDialog(Boolean lightMode, int language)
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
            if (language == -1 || language == 0)
            {
                Title.Text = "Add task";
                TaskName.Text = "Task name:";
                TaskDescription.Text = "Task description:";
                TaskDeadline.Text = "Task deadline:";
                button3.Text = "Confirm task";
                button4.Text = "Cancel";
            } else if (language == 1)
            {
                Title.Text = "Přidání úkolu";
                TaskName.Text = "Název úkolu:";
                TaskDescription.Text = "Popis úkolu:";
                TaskDeadline.Text = "Konečný termín:";
                button3.Text = "Uložit úkol";
                button4.Text = "Zrušit";
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

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
