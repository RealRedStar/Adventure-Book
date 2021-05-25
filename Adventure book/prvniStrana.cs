using System;
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
            form.chestroom.BackColor = form.pushed;
            form.calendar.BackColor = form.unpushed;
            form.character.BackColor = form.unpushed;
            form.settings.BackColor = form.unpushed;
            form.character.Image = Properties.Resources.userBlue;
            form.calendar.Image = Properties.Resources.calendarBlue;
            form.chestroom.Image = Properties.Resources.chestWhite;
            form.settings.Image = Properties.Resources.gearBlue;
        }
    }
}
