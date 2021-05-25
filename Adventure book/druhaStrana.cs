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
            form.chestroom.BackColor = form.unpushed;
            form.calendar.BackColor = form.pushed;
            form.character.BackColor = form.unpushed;
            form.settings.BackColor = form.unpushed;
            form.character.Image = Properties.Resources.userBlue;
            form.calendar.Image = Properties.Resources.calendarWhite;
            form.chestroom.Image = Properties.Resources.chestBlue;
            form.settings.Image = Properties.Resources.gearBlue;
        }
    }
}
