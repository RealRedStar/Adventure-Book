
using System;

namespace Adventure_book
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.magicalChestLabel = new System.Windows.Forms.Label();
            this.normalChestLabel = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.character = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Button();
            this.chestroom = new System.Windows.Forms.Button();
            this.magicalChest = new System.Windows.Forms.Button();
            this.normalChest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 38);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adventure Task Book";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(574, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(612, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.magicalChestLabel);
            this.panel2.Controls.Add(this.normalChestLabel);
            this.panel2.Controls.Add(this.magicalChest);
            this.panel2.Controls.Add(this.normalChest);
            this.panel2.Location = new System.Drawing.Point(95, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 326);
            this.panel2.TabIndex = 1;
            // 
            // magicalChestLabel
            // 
            this.magicalChestLabel.AutoSize = true;
            this.magicalChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.magicalChestLabel.ForeColor = System.Drawing.Color.White;
            this.magicalChestLabel.Location = new System.Drawing.Point(420, 282);
            this.magicalChestLabel.Name = "magicalChestLabel";
            this.magicalChestLabel.Size = new System.Drawing.Size(18, 20);
            this.magicalChestLabel.TabIndex = 9;
            this.magicalChestLabel.Text = "1";
            this.magicalChestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalChestLabel
            // 
            this.normalChestLabel.AutoSize = true;
            this.normalChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normalChestLabel.ForeColor = System.Drawing.Color.White;
            this.normalChestLabel.Location = new System.Drawing.Point(138, 282);
            this.normalChestLabel.Name = "normalChestLabel";
            this.normalChestLabel.Size = new System.Drawing.Size(18, 20);
            this.normalChestLabel.TabIndex = 8;
            this.normalChestLabel.Text = "0";
            this.normalChestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Image = global::Adventure_book.Properties.Resources.gearBlack;
            this.settings.Location = new System.Drawing.Point(12, 305);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(77, 77);
            this.settings.TabIndex = 6;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.character.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.character.ForeColor = System.Drawing.Color.White;
            this.character.Image = global::Adventure_book.Properties.Resources.userBlack;
            this.character.Location = new System.Drawing.Point(12, 222);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(77, 77);
            this.character.TabIndex = 5;
            this.character.UseVisualStyleBackColor = false;
            this.character.Click += new System.EventHandler(this.character_Click);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.ForeColor = System.Drawing.Color.White;
            this.calendar.Image = global::Adventure_book.Properties.Resources.calendarBlack;
            this.calendar.Location = new System.Drawing.Point(12, 139);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(77, 77);
            this.calendar.TabIndex = 4;
            this.calendar.UseVisualStyleBackColor = false;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // chestroom
            // 
            this.chestroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.chestroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chestroom.ForeColor = System.Drawing.Color.White;
            this.chestroom.Image = global::Adventure_book.Properties.Resources.chestBlack;
            this.chestroom.Location = new System.Drawing.Point(12, 56);
            this.chestroom.Name = "chestroom";
            this.chestroom.Size = new System.Drawing.Size(77, 77);
            this.chestroom.TabIndex = 3;
            this.chestroom.UseVisualStyleBackColor = false;
            this.chestroom.Click += new System.EventHandler(this.chestroom_Click);
            // 
            // magicalChest
            // 
            this.magicalChest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.magicalChest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicalChest.ForeColor = System.Drawing.Color.White;
            this.magicalChest.Image = global::Adventure_book.Properties.Resources.magicalChest;
            this.magicalChest.Location = new System.Drawing.Point(354, 129);
            this.magicalChest.Name = "magicalChest";
            this.magicalChest.Size = new System.Drawing.Size(150, 150);
            this.magicalChest.TabIndex = 7;
            this.magicalChest.UseVisualStyleBackColor = false;
            // 
            // normalChest
            // 
            this.normalChest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.normalChest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalChest.ForeColor = System.Drawing.Color.White;
            this.normalChest.Image = global::Adventure_book.Properties.Resources.normalChest;
            this.normalChest.Location = new System.Drawing.Point(73, 129);
            this.normalChest.Name = "normalChest";
            this.normalChest.Size = new System.Drawing.Size(150, 150);
            this.normalChest.TabIndex = 6;
            this.normalChest.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(671, 395);
            this.ControlBox = false;
            this.Controls.Add(this.settings);
            this.Controls.Add(this.character);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.chestroom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chestroom;
        private System.Windows.Forms.Button calendar;
        private System.Windows.Forms.Button character;
        private System.Windows.Forms.Button magicalChest;
        private System.Windows.Forms.Button normalChest;
        private System.Windows.Forms.Label magicalChestLabel;
        private System.Windows.Forms.Label normalChestLabel;
        private System.Windows.Forms.Button settings;
    }
}

