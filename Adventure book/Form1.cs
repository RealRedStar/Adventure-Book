using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_book
{
    public partial class Form1 : Form
    {


        public Point mouseLocation;

        Color unpushed = ColorTranslator.FromHtml("#4238FF");
        Color pushed = ColorTranslator.FromHtml("#00008B");
        public Form1()
        {
            InitializeComponent();
            chestroom.BackColor = pushed;
            chestroom.Image = Properties.Resources.chestWhite;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void chestroom_Click(object sender, EventArgs e)
        {
            chestroom.BackColor = pushed;
            calendar.BackColor = unpushed;
            character.BackColor = unpushed;
            settings.BackColor = unpushed;
            character.Image = Properties.Resources.userBlack;
            calendar.Image = Properties.Resources.calendarBlack;
            chestroom.Image = Properties.Resources.chestWhite;
            settings.Image = Properties.Resources.gearBlack;

        }

        private void calendar_Click(object sender, EventArgs e)
        {
            chestroom.BackColor = unpushed;
            calendar.BackColor = pushed;
            character.BackColor = unpushed;
            settings.BackColor = unpushed;
            character.Image = Properties.Resources.userBlack;
            calendar.Image = Properties.Resources.calendarWhite;
            chestroom.Image = Properties.Resources.chestBlack;
            settings.Image = Properties.Resources.gearBlack;
        }

        private void character_Click(object sender, EventArgs e)
        {
            chestroom.BackColor = unpushed;
            calendar.BackColor = unpushed;
            character.BackColor = pushed;
            settings.BackColor = unpushed;
            character.Image = Properties.Resources.userWhite;
            calendar.Image = Properties.Resources.calendarBlack;
            chestroom.Image = Properties.Resources.chestBlack;
            settings.Image = Properties.Resources.gearBlack;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            chestroom.BackColor = unpushed;
            calendar.BackColor = unpushed;
            character.BackColor = unpushed;
            settings.BackColor = pushed;
            character.Image = Properties.Resources.userBlack;
            calendar.Image = Properties.Resources.calendarBlack;
            chestroom.Image = Properties.Resources.chestBlack;
            settings.Image = Properties.Resources.gearWhite;

        }
    }
}
