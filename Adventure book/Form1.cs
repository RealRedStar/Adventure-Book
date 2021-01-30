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

        Color unpushed = ColorTranslator.FromHtml("#252526");
        Color pushed = ColorTranslator.FromHtml("#007ACC");
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
            character.Image = Properties.Resources.userBlue;
            calendar.Image = Properties.Resources.calendarBlue;
            chestroom.Image = Properties.Resources.chestWhite;
            settings.Image = Properties.Resources.gearBlue;

            chestEnable();


        }

        private void calendar_Click(object sender, EventArgs e)
        {
            chestroom.BackColor = unpushed;
            calendar.BackColor = pushed;
            character.BackColor = unpushed;
            settings.BackColor = unpushed;
            character.Image = Properties.Resources.userBlue;
            calendar.Image = Properties.Resources.calendarWhite;
            chestroom.Image = Properties.Resources.chestBlue;
            settings.Image = Properties.Resources.gearBlue;
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
            calendar.Image = Properties.Resources.calendarBlue;
            chestroom.Image = Properties.Resources.chestBlue;
            settings.Image = Properties.Resources.gearBlue;

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
            character.Image = Properties.Resources.userBlue;
            calendar.Image = Properties.Resources.calendarBlue;
            chestroom.Image = Properties.Resources.chestBlue;
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
        
        // Od tohoto řádku začíná obří kód změny obrázků
        // magicalChest - Image changing
        private bool ClickMeButtonIsPressed = false;





        // Display the button down image.
        private void magicalChest_MouseDown(object sender, MouseEventArgs e)
        {
            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                ClickMeButtonIsPressed = true;
                magicalChest.Image = Properties.Resources.magicalChestBigClicked;
            }
        }

        // Display the button up image.
        private void magicalChest_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            magicalChest.Image = Properties.Resources.magicalChestBig;
        }

        // If the button is pressed, display the appropriate image.
        private void magicalChest_MouseMove(object sender, MouseEventArgs e)
        {
            // The picture the button should have.
            Image desired_picture = Properties.Resources.magicalChestBig;

            // See if the mouse is over the button's masked area.
            if (MouseIsOverButton(e.Location))
            {
                // The mouse is over the masked area.
                // See if the mouse is pressed.
                if (ClickMeButtonIsPressed)
                    desired_picture = Properties.Resources.magicalChestBigClicked;
                else
                    desired_picture = Properties.Resources.magicalChestBig;
            }
            else
            {
                // The mouse is not over the masked area.
                // The button should be in the up position.
                desired_picture = Properties.Resources.magicalChestBig;
            }

            // See if we need to change the button image.
            if (magicalChest.Image != desired_picture)
                magicalChest.Image = desired_picture;
        }

        // Return true if the mouse is over the button's masked area.
        private bool MouseIsOverButton(Point location)
        {
            // Make sure the location is over the image.
            if (location.X < 0) return false;
            if (location.Y < 0) return false;
            if (location.X >= Properties.Resources.magicalChestBigMask.Width) return false;
            if (location.Y >= Properties.Resources.magicalChestBigMask.Height) return false;

            // See if the mask pixel at this position is black.
            Color color =
                Properties.Resources.magicalChestBigMask.GetPixel(
                    location.X, location.Y);
            return ((color.A == 255) &&
                    (color.R == 0) &&
                    (color.G == 0) &&
                    (color.B == 0));
        }

        // The button has been clicked.

        // magicalChest - klik
        private void magicalChest_Click(object sender, MouseEventArgs e)
        {
            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                if (int.Parse(magicalChestLabel.Text) > 0)
                {
                    magicalChestLabel.Text = (int.Parse(magicalChestLabel.Text) - 1).ToString();
                }
            }
        }

        //normalChest - změna obrázků
        private void normalChest_MouseDown(object sender, MouseEventArgs e)
        {
            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                ClickMeButtonIsPressed = true;
                normalChest.Image = Properties.Resources.normalChestBigClicked;
            }
        }

        // Display the button up image.
        private void normalChest_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            normalChest.Image = Properties.Resources.normalChestBig;
        }

        // If the button is pressed, display the appropriate image.
        private void normalChest_MouseMove(object sender, MouseEventArgs e)
        {
            // The picture the button should have.
            Image desired_picture = Properties.Resources.normalChestBig;

            // See if the mouse is over the button's masked area.
            if (MouseIsOverButton(e.Location))
            {
                // The mouse is over the masked area.
                // See if the mouse is pressed.
                if (ClickMeButtonIsPressed)
                    desired_picture = Properties.Resources.normalChestBigClicked;
                else
                    desired_picture = Properties.Resources.normalChestBig;
            }
            else
            {
                // The mouse is not over the masked area.
                // The button should be in the up position.
                desired_picture = Properties.Resources.normalChestBig;
            }

            // See if we need to change the button image.
            if (normalChest.Image != desired_picture)
                normalChest.Image = desired_picture;
        }

        // Return true if the mouse is over the button's masked area.

        // The button has been clicked.

        //normalChest - klik
        private void normalChest_Click(object sender, MouseEventArgs e)
        {
            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                if (int.Parse(normalChestLabel.Text) > 0)
                {
                    normalChestLabel.Text = (int.Parse(normalChestLabel.Text) - 1).ToString();
                }
            }
        }
    }
}
