using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devise
{
    public partial class F_InternetUser : Form
    {
        public F_InternetUser()
        {
            InitializeComponent();
        }

        private void F_InternetUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_InternetUser". При необходимости она может быть перемещена или удалена.
            this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_InternetUser". При необходимости она может быть перемещена или удалена.
            this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);

        }
    }
}
