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

        public void chestEnable()
        {
            normalChest.Visible = true;
            magicalChest.Visible = true;

            normalChestLabel.Visible = true;
            magicalChestLabel.Visible = true;
        }
        public void chestDisable()
        {
            normalChest.Visible = false;
            magicalChest.Visible = false;

            normalChestLabel.Visible = false;
            magicalChestLabel.Visible = false;
        }

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

            chestEnable();


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
            normalChest.Visible = false;

            chestDisable();
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

            chestDisable();
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

            chestDisable();

        }

        private void normalChest_Click(object sender, EventArgs e)
        {
            if (int.Parse(normalChestLabel.Text) > 0)
            {
                normalChestLabel.Text = (int.Parse(normalChestLabel.Text) - 1).ToString();
            }
        }

        private void magicalChest_Click(object sender, EventArgs e)
        {
            if (int.Parse(magicalChestLabel.Text) > 0)
            {
                magicalChestLabel.Text = (int.Parse(magicalChestLabel.Text) - 1).ToString();
            }
        }
    }
}
