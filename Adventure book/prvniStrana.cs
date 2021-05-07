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
        Color unpushed = ColorTranslator.FromHtml("#252526");
        Color pushed = ColorTranslator.FromHtml("#007ACC");
        public void activate(Form1 form)
        {
            form.chestroom.BackColor = pushed;
            form.calendar.BackColor = unpushed;
            form.character.BackColor = unpushed;
            form.settings.BackColor = unpushed;
            form.character.Image = Properties.Resources.userBlue;
            form.calendar.Image = Properties.Resources.calendarBlue;
            form.chestroom.Image = Properties.Resources.chestWhite;
            form.settings.Image = Properties.Resources.gearBlue;
            //lol
        }
    }
}
