using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Devise
{
    class Exel
    {
        public Exel(DataGridView dataGridView1, string Name)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);
            excelApp.Sheets[1].Activate();
            Excel.Worksheet worksheet;
            worksheet = (Excel.Worksheet)excelApp.Worksheets.get_Item(1);
            (excelApp.Sheets[1] as Excel.Worksheet).Name = $"{Name}";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                excelApp.Cells[2, i + 2] = $"{dataGridView1.Columns[i].HeaderText.ToString()}";
                excelApp.Cells[2, i + 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelApp.Cells[i + 3, j + 2] = $"{dataGridView1.Rows[i].Cells[j].Value.ToString()}";
                    excelApp.Cells[i + 3, j + 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                }
            }
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
