using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Devise
{
    class Spravka
    {
        public Spravka()
        {
            string c = "D:/Csharp_Progect/Devise/Devise/Sprav/vvedenie.htm";
            var op = new Process();
            op.StartInfo.FileName = c;
            op.Start();
        }
    }
}
