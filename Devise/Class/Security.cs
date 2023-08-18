using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Devise
{
    internal class Security
    {

        public Security(int level)
        {
            Holder.level = level;
            switch (level)
            {
                case 0:
                    Holder.securityName = "Администратор";
                    break;
                case 1:
                    Holder.securityName = "Менеджер";
                    break;
                case 2:
                    Holder.securityName = "Покупатель";
                    break;
            }
        }
    }
    public static class Holder
    {
        public static Timer Timers;
        public static Label Time;
        public static int level { get; set; }
        public static string securityName { get; set; }
        public static bool TestTatus { get; set; } = false;
        public static string UnitTest_Put { get; set; }
        public static string FIO_Full { get; set; }
        public static string FIO_Socroshen { get; set; }

    }

}
