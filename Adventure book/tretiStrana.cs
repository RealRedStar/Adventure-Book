using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_book
{
    class tretiStrana
    {

        public void activate(Form1 form)
        {
            form.chestroom.BackColor = form.unpushed;
            form.calendar.BackColor = form.unpushed;
            form.character.BackColor = form.pushed;
            form.settings.BackColor = form.unpushed;
            form.character.Image = Properties.Resources.userWhite;
            form.calendar.Image = Properties.Resources.calendarBlue;
            form.chestroom.Image = Properties.Resources.chestBlue;
            form.settings.Image = Properties.Resources.gearBlue;

        }
    }
}
