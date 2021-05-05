﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_book
{
    class ctvrtaStrana
    {
        Color unpushed = ColorTranslator.FromHtml("#252526");
        Color pushed = ColorTranslator.FromHtml("#007ACC");
        public void activate(Form1 form)
        {
            form.chestroom.BackColor = unpushed;
            form.calendar.BackColor = unpushed;
            form.character.BackColor = unpushed;
            form.settings.BackColor = pushed;
            form.character.Image = Properties.Resources.userBlue;
            form.calendar.Image = Properties.Resources.calendarBlue;
            form.chestroom.Image = Properties.Resources.chestBlue;
            form.settings.Image = Properties.Resources.gearWhite;

        }
    }
}