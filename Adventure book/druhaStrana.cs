using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_book 
{
    class druhaStrana
    {

        public void activate(Form1 form)
        {
            form.Chestroom.BackColor = form.unpushed;
            form.Calendar.BackColor = form.pushed;
            form.Character.BackColor = form.unpushed;
            form.SettingsMenu.BackColor = form.unpushed;
            form.Character.Image = Properties.Resources.userBlue;
            form.Calendar.Image = Properties.Resources.calendarWhite;
            form.Chestroom.Image = Properties.Resources.chestBlue;
            form.SettingsMenu.Image = Properties.Resources.gearBlue;
        }
    }
}
