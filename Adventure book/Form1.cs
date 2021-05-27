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


        public Color unpushed = ColorTranslator.FromHtml("#252526");
        public Color pushed = ColorTranslator.FromHtml("#007ACC");
        int mouseX;
        int mouseY;
        int mouseinX;
        int mouseinY;
        Boolean mouseDown;
        MainDirectory mn = new MainDirectory();
        readonly string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt";
        readonly string settingsPath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Settings.txt";
        readonly string userStats = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\UserStats.txt";
        int CoinsOwned = 0;
        Boolean lightMode;
        public Form1()
        {
            InitializeComponent();


            Chestroom.Image = Properties.Resources.chestWhite;
            AddDialog addDialog = new AddDialog(lightMode);
            DataToTable();
            menu1.Visible = true;
            mn.Exist();
            Settings();
            GetUserStats();
            Chestroom.BackColor = pushed;
            SettingsMenu.BackColor = unpushed;
            
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
        public void GetUserStats() 
        {
            try
            {
                string[] lines;
                using (StreamReader stream = new StreamReader(userStats))
                {
                    lines = stream.ReadLine().Split();
                    NormalChestLabel.Text = lines[1];
                    lines = stream.ReadLine().Split();
                    MagicalChestLabel.Text = lines[1];
                    lines = stream.ReadLine().Split();
                    Coins.Text = lines[1];
                }
            } catch(NullReferenceException)
            {
                SetUserStats();
            }
        }

        public void SetUserStats()
        {
            if (File.Exists(userStats))
            {
                File.Delete(userStats);
                File.Create(userStats).Close();
                using (StreamWriter stream = File.AppendText(userStats))
                {
                    stream.WriteLine("NormalChest: " + NormalChestLabel.Text);
                    stream.WriteLine("MagicalChest: " + MagicalChestLabel.Text);
                    stream.WriteLine("Coins: " + Coins.Text);
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }        
        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void Chestroom_Click(object sender, EventArgs e)
        {
            prvniStrana pr = new prvniStrana();
            pr.activate(this);
            menu1.Visible = true;
            menu2.Visible = false;
            menu3.Visible = false;
            menu4.Visible = false;


        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            druhaStrana dr = new druhaStrana();
            dr.activate(this);
            menu1.Visible = false;
            menu2.Visible = true;
            menu3.Visible = false;
            menu4.Visible = false;
        }

        private void Character_Click(object sender, EventArgs e)
        {
            tretiStrana tr = new tretiStrana();
            tr.activate(this);
            menu1.Visible = false;
            menu2.Visible = false;
            menu3.Visible = true;
            menu4.Visible = false;
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            ctvrtaStrana ct = new ctvrtaStrana();
            ct.activate(this);
            menu1.Visible = false;
            menu2.Visible = false;
            menu3.Visible = false;
            menu4.Visible = true;

        }

        

        private void NormalChest_Click(object sender, EventArgs e)
        {
            if (int.Parse(NormalChestLabel.Text) > 0)
            {
                NormalChestLabel.Text = (int.Parse(NormalChestLabel.Text) - 1).ToString();
            }
        }
        
        // Od tohoto řádku začíná obří kód změny obrázků
        // magicalChest - Image changing
        private bool ClickMeButtonIsPressed = false;





        // Display the button down image.
        private void MagicalChest_MouseDown(object sender, MouseEventArgs e)
        {
            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                ClickMeButtonIsPressed = true;
                magicalChest.Image = Properties.Resources.magicalChestBigClicked;
            }
        }

        // Display the button up image.
        private void MagicalChest_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            magicalChest.Image = Properties.Resources.magicalChestBig;
        }

        // If the button is pressed, display the appropriate image.
        private void MagicalChest_MouseMove(object sender, MouseEventArgs e)
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
        private void MagicalChest_Click(object sender, MouseEventArgs e)
        {
            //Přidání peněz:
            if (int.Parse(MagicalChestLabel.Text) > 0)
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
                if (int.Parse(MagicalChestLabel.Text) > 0)
                {
                    MagicalChestLabel.Text = (int.Parse(MagicalChestLabel.Text) - 1).ToString();
                }
            }
            SetUserStats();
        }

        //normalChest - změna obrázků
        private void NormalChest_MouseDown(object sender, MouseEventArgs e)
        {
            // See if the mouse is over the masked area.
            if (MouseIsOverButton(e.Location))
            {
                ClickMeButtonIsPressed = true;
                NormalChest.Image = Properties.Resources.normalChestBigClicked;
            }
        }

        // Display the button up image.
        private void NormalChest_MouseUp(object sender, MouseEventArgs e)
        {
            ClickMeButtonIsPressed = false;
            NormalChest.Image = Properties.Resources.normalChestBig;
        }

        // If the button is pressed, display the appropriate image.
        private void NormalChest_MouseMove(object sender, MouseEventArgs e)
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
            if (NormalChest.Image != desired_picture)
                NormalChest.Image = desired_picture;
        }

        // Return true if the mouse is over the button's masked area.

        // The button has been clicked.

        //normalChest - klik
        private void NormalChest_Click(object sender, MouseEventArgs e)
        {
            //Přidání peněz:
            if (int.Parse(NormalChestLabel.Text) > 0)
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
                if (int.Parse(NormalChestLabel.Text) > 0)
                {
                    NormalChestLabel.Text = (int.Parse(NormalChestLabel.Text) - 1).ToString();
                }
            }
            SetUserStats();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Menu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddHomework_Click(object sender, EventArgs e)
        {
            AddDialog dialog = new AddDialog(lightMode);
            dialog.ShowDialog();
            DataToTable();
        }

        private void Button3_Click(object sender, EventArgs e)
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
        private void Button4_Click(object sender, EventArgs e)
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
                int chestRate = new Random().Next(0, 100);
                if (chestRate <= 5)
                {
                    int tmp = int.Parse(MagicalChestLabel.Text);
                    tmp++;
                    MagicalChestLabel.Text = tmp.ToString();
                } 
                else
                {
                    int tmp = int.Parse(NormalChestLabel.Text);
                    tmp++;
                    NormalChestLabel.Text = tmp.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Není vybrána žádná hodnota, nebo je tabulka prázdná.");
            }

            DataToTable();
            SetUserStats();


        }

        private void DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Coins_TextChanged(object sender, EventArgs e)
        {

        }

        private void NormalChestLabel_Click(object sender, EventArgs e)
        {

        }

        private void MagicalChestLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LightMode_CheckedChanged(object sender, EventArgs e)
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
                CoinsLabel.ForeColor = ColorTranslator.FromHtml("#000000");
                NormalChestLabel.ForeColor = ColorTranslator.FromHtml("#000000");
                MagicalChestLabel.ForeColor = ColorTranslator.FromHtml("#000000");
                BackColor = ColorTranslator.FromHtml("#FFFFFF");
                AddHomework.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                AddHomework.ForeColor = ColorTranslator.FromHtml("#000000");
                button4.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button4.ForeColor = ColorTranslator.FromHtml("#000000");
                button3.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                button3.ForeColor = ColorTranslator.FromHtml("#000000");
                MinimizeButton.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                MinimizeButton.ForeColor = ColorTranslator.FromHtml("#000000");
                ExitButton.BackColor = ColorTranslator.FromHtml("#E8E8E8");
                ExitButton.ForeColor = ColorTranslator.FromHtml("#000000");
                LanguageTxt.ForeColor = ColorTranslator.FromHtml("#000000");
                Chestroom.BackColor = unpushed;
                Calendar.BackColor = unpushed;
                Character.BackColor = unpushed;
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
                CoinsLabel.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                NormalChestLabel.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                MagicalChestLabel.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                AddHomework.BackColor = ColorTranslator.FromHtml("#242425");
                AddHomework.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                ExitButton.BackColor = ColorTranslator.FromHtml("#242425");
                ExitButton.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                MinimizeButton.BackColor = ColorTranslator.FromHtml("#242425");
                MinimizeButton.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                button3.BackColor = ColorTranslator.FromHtml("#242425");
                button3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                button4.BackColor = ColorTranslator.FromHtml("#242425");
                button4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                LanguageTxt.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                Chestroom.BackColor = unpushed;
                Calendar.BackColor = unpushed;
                Character.BackColor = unpushed;
                lightMode = false;
                ToSettings();

            }
        }

        private void LanguageTxt_Click(object sender, EventArgs e)
        {

        }

        private void LanguageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageSelect.SelectedItem.Equals("Čeština"))
            {
                label1.Text = "Dobrodružný úkolníček";
                label2.Text = "Nastavení";
                label4.Text = "Bílý režim:";
                LanguageTxt.Text = "Jazyk:";
                CoinsLabel.Text = "Mince:";
            } else if (LanguageSelect.SelectedItem.Equals("English"))
            {
                label1.Text = "Adventure Task Book";
                label2.Text = "Settings";
                label4.Text = "White Mode:";
                LanguageTxt.Text = "Language:";
                CoinsLabel.Text = "Coins:";
            }
        }
    }
}
