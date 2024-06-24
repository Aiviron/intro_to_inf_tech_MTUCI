using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataNamespace;
namespace Lab3_sem2
{
    public partial class Lab4ResultForm : Form
    {
        public Lab4ResultForm()
        {
            InitializeComponent();
            results.ColumnCount = DataForLab4.result.Length;
            results.RowCount = 2;
            results.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            for (int i = 0; i < DataForLab4.result.Length; i++)
            {
                results.Rows[0].Cells[i].Value = "Вопрос [" + (i+1) + "]";
                results.Rows[1].Cells[i].Value = DataForLab4.result[i];
                if (DataForLab4.correct_answers_cnt < 2)
                {
                    label1.Text = "Ваша оценка - 2";
                }
                else
                {
                    label1.Text = "Ваша оценка - " + DataForLab4.correct_answers_cnt;
                }
            }
        }


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1] = "Результаты опроса";

            int row = 2;
            int col = 1;
            foreach (DataGridViewColumn column in results.Columns)
            {
                worksheet.Cells[row, col] = column.HeaderText;
                col++;
            }

            row++;
            col = 1;
            foreach (DataGridViewRow dataRow in results.Rows)
            {
                foreach (DataGridViewCell cell in dataRow.Cells)
                {
                    worksheet.Cells[row, col] = cell.Value;
                    col++;
                }
                row++;
                col = 1;
            }

            excelApp.Visible = true;
        }


    }

}



   

