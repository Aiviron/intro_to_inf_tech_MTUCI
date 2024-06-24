using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using DLL_sem2;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;

namespace Lab3Sem2
{
    public partial class Lab3CalculateForm : Form
    {
        public Lab3CalculateForm()
        {
            InitializeComponent();
        }

        public int[] array;
        public int[] array2;

        private void сalculateButton_Click(object sender, EventArgs e)
        {
            int array_length = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите длину массива", Title: "Ввод"));
            int min_range_value = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите минимальное значение диапазона генерации массива", Title: "Ввод"));
            int max_range_value = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите максимальное границу диапазона генерации массива", Title: "Ввод"));


            array = new int[array_length];

            LabFunctions.generateArray(array, array_length, min_range_value, max_range_value);
            LabFunctions.tabulateArrayToDataGridView(array, dataGridView1);

            int suitable_elements_cnt = LabFunctions.сonditionalСounter(array);
            MessageBox.Show("Найдено " + suitable_elements_cnt + " элементов");

            array2 = new int[array.Length];
            array2 = LabFunctions.сonditionalArray(array, suitable_elements_cnt);

            dataGridView2.Rows.Clear();
            LabFunctions.tabulateArrayToDataGridView(array2, dataGridView2);
        }

        private void сreateTextFile_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = File.CreateText("Массивы.txt");
            streamWriter.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                streamWriter.WriteLine(array[i].ToString());
            }
            streamWriter.WriteLine("Конечный массив:");
            for (int i = 0; i < array2.Length; i++)
            {
                streamWriter.WriteLine(array2[i].ToString());
            }

            streamWriter.Close();
            Process.Start("Массивы.txt");
        }

        private void createExcelFile_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook WB = excel.Workbooks.Add();
            Excel.Worksheet ws = WB.Worksheets[1];
            ws.Name = "Исходный массив";
            for (int i = 0; i < array.Length; i++)
            {
                ws.Cells[2, i + 1] = "[" + i + "]";
                ws.Cells[3, i + 1] = array[i].ToString();
            }
            Excel.Worksheet ws2 = WB.Worksheets.Add();
            ws2.Name = "Конечный массив";
            for (int i = 0; i < array2.Length; i++)
            {
                ws2.Cells[2, i + 1] = "[" + i + "]";
                ws2.Cells[3, i + 1] = array2[i].ToString();
            }
            excel.Visible = true;
            excel.UserControl = true;
        }


        private void createWordFile_Click(object sender, EventArgs e)
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Range range = doc.Range();
            

            range.Text = "Исходный массив:\n";
            for (int i = 0; i < array.Length; i++)
            {
                range.Text += "[" + i + "] " + array[i].ToString() + "\n";
            }

            range.Text += "\nКонечный массив:\n";
            for (int i = 0; i < array2.Length; i++)
            {
                range.Text += "[" + i + "] " + array2[i].ToString() + "\n";
            }

            word.Visible = true;
        }


    }
}


