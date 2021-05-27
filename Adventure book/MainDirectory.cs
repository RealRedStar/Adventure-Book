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
                File.Create(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt").Close();
                File.WriteAllText(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Settings.txt", "light-mode: true");
                File.Create(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\UserStats.txt").Close();
                using (StreamWriter streamWriter = File.AppendText(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\UserStats.txt"))
                {
                    streamWriter.WriteLine("NormalChest: 0");
                    streamWriter.WriteLine("MagicalChest: 0");
                    streamWriter.WriteLine("Coins: 0");
                    streamWriter.Close();
                }
            } else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt"))
                {
                    File.Create(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Data.txt");
                }
                if (!File.Exists(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Settings.txt"))
                {
                    File.WriteAllText(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\Settings.txt", "light-mode: true");
                }
                if (!File.Exists(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\UserStats.txt"))
                {
                    File.Create(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\UserStats.txt").Close();
                    using (StreamWriter streamWriter = File.AppendText(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\ATB\UserStats.txt"))
                    {
                        streamWriter.WriteLine("NormalChest: 0");
                        streamWriter.WriteLine("MagicalChest: 0");
                        streamWriter.WriteLine("Coins: 0");
                        streamWriter.Close();
                    }
                }
                
            }
        }
    }
}
