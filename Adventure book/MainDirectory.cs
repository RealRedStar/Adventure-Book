using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventure_book
{
    class MainDirectory
    {
        public void Exist()
        {
            if (!Directory.Exists(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB")) 
            {
                Directory.CreateDirectory(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB");
                File.Create(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt");
            } else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt"))
                {
                    File.Create(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt");
                }
            }
        }
    }
}
