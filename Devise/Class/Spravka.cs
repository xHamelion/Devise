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
            string c = $"{AppDomain.CurrentDomain.BaseDirectory}/Sprav/index.htm";
            var op = new Process();
            op.StartInfo.FileName = c;
            op.Start();
            op.Dispose();
        }
    }
}
