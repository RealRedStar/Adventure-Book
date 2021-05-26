﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_book
{
    class prvniStrana
    {
        
        public void activate(Form1 form)
        {
            form.Chestroom.BackColor = form.pushed;
            form.Calendar.BackColor = form.unpushed;
            form.Character.BackColor = form.unpushed;
            form.SettingsMenu.BackColor = form.unpushed;
            form.Character.Image = Properties.Resources.userBlue;
            form.Calendar.Image = Properties.Resources.calendarBlue;
            form.Chestroom.Image = Properties.Resources.chestWhite;
            form.SettingsMenu.Image = Properties.Resources.gearBlue;
        }
    }
}
