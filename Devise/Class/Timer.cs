using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Devise
{
    public class Timer
    {
        private static System.Timers.Timer aTimer;
        private static int TimeMinuts;
        private static int TimeTekush;
        private static Label labelS;

        

        public Timer(int minuts, Label label )
        {
            labelS = label;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Holder.Time.Text = DateTime.Now.ToLongTimeString();
            if (Holder.level != 0)
                labelS.Text = $"Осталось {minuts} минут до окончания сеанса";
            if (Holder.level == 0)
                labelS.Text = $"Веремя не ограничено";
            TimeMinuts = minuts * 60000;
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            Task.Delay(minuts * 60000).ContinueWith(p =>
            {
              
                if (Holder.level == 0)
                    return;
                aTimer.Stop();
                aTimer.Dispose();
                TimeTekush = 0;
                EndSession();
            });

        }
        public void StopSesion()
        {
            aTimer.Stop();
            aTimer.Dispose();
            TimeTekush = 0;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;

        }
       static  Thread t = new Thread(() => MessageBox.Show("Конец сессии!"));
        private void EndSession()
        {

            t.Abort();
            int col = Application.OpenForms.Count-1;
            for (int i = col; col != 0; col--)
            {
                Application.OpenForms[col].Close();
            }
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;
            TimeTekush = 0;



        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
            Holder.Time.Text = e.SignalTime.ToLongTimeString();//.ToLongTimeString()
            TimeTekush += 1000;
            if(Holder.level != 0)
                labelS.Text = $"Осталось {Convert.ToInt32((TimeMinuts - TimeTekush)/60000)} минут до окончания сеанса";


            if (TimeTekush == TimeMinuts - 10000 && Holder.level != 0)
                t.Start();

            int minutsTek = Convert.ToInt32(TimeTekush / 60000);
            if (TimeMinuts / 2 == TimeTekush && Holder.level != 0)
            {
                MessageBox.Show($"Половина сессии!\n" +
                    $"Осталось {(TimeMinuts / 60000) - minutsTek} минут!","Внимение!" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
