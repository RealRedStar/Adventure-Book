using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Adventure_book
{
    public partial class Form1 : Form
    {


        public Point mouseLocation;

        // - Již staré metody
        //public void chestEnable()
        //{
        //    normalChest.Visible = true;
        //    magicalChest.Visible = true;

        //    normalChestLabel.Visible = true;
        //    magicalChestLabel.Visible = true;
        //}
        //public void chestDisable()
        //{
        //    normalChest.Visible = false;
        //    magicalChest.Visible = false;

        //    normalChestLabel.Visible = false;
        //    magicalChestLabel.Visible = false;
        //}

        public Color unpushed = ColorTranslator.FromHtml("#252526");
        public Color pushed = ColorTranslator.FromHtml("#007ACC");
        int mouseX;
        int mouseY;
        int mouseinX;
        int mouseinY;
        Boolean mouseDown;
        MainDirectory mn = new MainDirectory();
        string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt";
        string settingsPath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Settings.txt";
        int CoinsOwned = 0;
        Boolean lightMode;
        public Form1()
        {
            InitializeComponent();


            chestroom.Image = Properties.Resources.chestWhite;
            AddDialog addDialog = new AddDialog(lightMode);
            DataToTable();
            menu1.Visible = true;
            mn.Exist();
            Settings();
            chestroom.BackColor = pushed;
            settings.BackColor = unpushed;
            
        }


        public void Settings()
        {
            try
            {
                String[] text = File.ReadAllLines(settingsPath);
                try
                {
                    if (text[0].Contains("true"))
                    {
                        whiteMode.Checked = true;
                        lightMode = true;
                    }
                    else
                    {
                        whiteMode.Checked = false;
                        lightMode = false;
                    }
                } catch(IndexOutOfRangeException)
                {
                    ToSettings();
                }
            } catch(NullReferenceException)
            {
                ToSettings();
            }
            
        }
        public void ToSettings()
        {
            if (lightMode)
            {
                if (File.Exists(settingsPath))
                {
                    File.Delete(settingsPath);
                    File.WriteAllText(settingsPath, "light-mode: true");
                } else
                {
                    File.WriteAllText(settingsPath, "light-mode: true");
                }
            }
            else
            {
                if (File.Exists(settingsPath))
                {
                    File.Delete(settingsPath);
                    File.WriteAllText(settingsPath, "light-mode: false");
                }
                else
                {
                    File.WriteAllText(settingsPath, "light-mode: false");
                }
            }
        }

        public void DataToTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(String));
            table.Columns.Add("Název", typeof(String));
            table.Columns.Add("Info", typeof(String));
            table.Columns.Add("Datum", typeof(String));
            using (StreamReader streamReader = new StreamReader(path))
            {
                for (int i = 0; i < File.ReadLines(path).Count(); i++)
                {
                    DataRow row = table.NewRow();
                    string line = streamReader.ReadLine();
                    string[] lines = line.Split(';');
                    for (int j = 0; j < 4; j++)
                    {
                        row[j] = lines[j];
                    }
                    table.Rows.Add(row[0], row[1], row[2], row[3]);
                }
                streamReader.Close();
            }
            DataGrid.DataSource = table;
            DataGrid.Visible = true;
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
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }        
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void chestroom_Click(object sender, EventArgs e)
        {
            prvniStrana pr = new prvniStrana();
            pr.activate(this);
            menu1.Visible = true;
            menu2.Visible = false;
            menu3.Visible = false;
            menu4.Visible = false;


        }

        private void calendar_Click(object sender, EventArgs e)
        {
            druhaStrana dr = new druhaStrana();
            dr.activate(this);
            menu1.Visible = false;
            menu2.Visible = true;
            menu3.Visible = false;
            menu4.Visible = false;
        }

        private void character_Click(object sender, EventArgs e)
        {
            tretiStrana tr = new tretiStrana();
            tr.activate(this);
            menu1.Visible = false;
            menu2.Visible = false;
            menu3.Visible = true;
            menu4.Visible = false;
        }
        private void settings_Click(object sender, EventArgs e)
        {
            ctvrtaStrana ct = new ctvrtaStrana();
            ct.activate(this);
            menu1.Visible = false;
            menu2.Visible = false;
            menu3.Visible = false;
            menu4.Visible = true;

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
            //Přidání peněz:
            if (int.Parse(magicalChestLabel.Text) > 0)
            {
                Random rnd = new Random();
                this.CoinsOwned += rnd.Next(100, 200);
                Coins.Text = this.CoinsOwned.ToString();
            }
            else
            {
                MessageBox.Show("Nemáte žádné truhy k otevření.");
            }

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
            //Přidání peněz:
            if (int.Parse(normalChestLabel.Text) > 0)
            {
                Random rnd = new Random();
                this.CoinsOwned += rnd.Next(10, 100);
                Coins.Text = this.CoinsOwned.ToString();
            }
            else
            {
                MessageBox.Show("Nemáte žádné truhy k otevření.");
            }

            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                if (int.Parse(normalChestLabel.Text) > 0)
                {
                    normalChestLabel.Text = (int.Parse(normalChestLabel.Text) - 1).ToString();
                }
            }
        }

        private void magicalChest_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddHomework_Click(object sender, EventArgs e)
        {
            AddDialog dialog = new AddDialog(lightMode);
            dialog.ShowDialog();
            DataToTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList text = new ArrayList();
            try
            {
                int index = DataGrid.CurrentCell.RowIndex;
                using (StreamReader streamReader = new StreamReader(path))
                {
                    for (int i = 0; i < File.ReadLines(path).Count(); i++)
                    {
                        text.Add(streamReader.ReadLine());
                    }
                }
                File.Delete(path);

                using (StreamWriter writer = File.AppendText(path))
                {
                    for (int i = 0; i < text.Count; i++)
                    {
                        if (i != index)
                        {
                            writer.WriteLine(text[i]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Není vybrána žádná hodnota, nebo je tabulka prázdná.");
            }

            DataToTable();
        }

        private void DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Coins_TextChanged(object sender, EventArgs e)
        {

        }

        private void normalChestLabel_Click(object sender, EventArgs e)
        {

        }

        private void magicalChestLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void whiteMode_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteMode.Checked)
            {
                unpushed = ColorTranslator.FromHtml("#E8E8E8");
                menu1.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                menu2.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                menu3.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                menu4.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                panel1.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                label1.ForeColor = ColorTranslator.FromHtml("#000000");
                label2.ForeColor = ColorTranslator.FromHtml("#000000");
                label4.ForeColor = ColorTranslator.FromHtml("#000000");
                txtCoins.ForeColor = ColorTranslator.FromHtml("#000000");
                normalChestLabel.ForeColor = ColorTranslator.FromHtml("#000000");
                magicalChestLabel.ForeColor = ColorTranslator.FromHtml("#000000");
                BackColor = ColorTranslator.FromHtml("#FFFFFF");
                AddHomework.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                AddHomework.ForeColor = ColorTranslator.FromHtml("#000000");
                button3.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button3.ForeColor = ColorTranslator.FromHtml("#000000");
                button2.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button2.ForeColor = ColorTranslator.FromHtml("#000000");
                button1.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button1.ForeColor = ColorTranslator.FromHtml("#000000");
                chestroom.BackColor = unpushed;
                calendar.BackColor = unpushed;
                character.BackColor = unpushed;
                lightMode = true;
                ToSettings();
            }
            else
            {
                unpushed = ColorTranslator.FromHtml("#252526");
                menu1.BackColor = ColorTranslator.FromHtml("#242425");
                menu2.BackColor = ColorTranslator.FromHtml("#242425");
                menu3.BackColor = ColorTranslator.FromHtml("#242425");
                menu4.BackColor = ColorTranslator.FromHtml("#242425");
                panel1.BackColor = ColorTranslator.FromHtml("#242425");
                label1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                label2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                label4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                txtCoins.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                normalChestLabel.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                magicalChestLabel.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                AddHomework.BackColor = ColorTranslator.FromHtml("#242425");
                AddHomework.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                button1.BackColor = ColorTranslator.FromHtml("#242425");
                button1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                button2.BackColor = ColorTranslator.FromHtml("#242425");
                button2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                button3.BackColor = ColorTranslator.FromHtml("#242425");
                button3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                chestroom.BackColor = unpushed;
                calendar.BackColor = unpushed;
                character.BackColor = unpushed;
                lightMode = false;
                ToSettings();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
