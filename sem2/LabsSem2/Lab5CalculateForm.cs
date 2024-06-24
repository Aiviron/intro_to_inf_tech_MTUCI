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
    public partial class Lab5CalculateForm : Form
    {
        public Lab5CalculateForm()
        {
            InitializeComponent();
        }

        public int[,] array;
        public int[] array2;

        private void сalculateButton_Click(object sender, EventArgs e)
        {
            int array_rows = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите количество строк массива", Title: "Ввод"));
            int array_cols = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите количество столбцов массива", Title: "Ввод"));
            int min_range_value = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите минимальное значение диапазона генерации массива", Title: "Ввод"));
            int max_range_value = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите максимальное границу диапазона генерации массива", Title: "Ввод"));

            array = new int[array_rows, array_cols];

            LabFunctions.generateArray2D(array, array_rows, array_cols, min_range_value, max_range_value);
            LabFunctions.tabulateArrayToDataGridView2D(array, dataGridView1);

            bool isEvenSum = LabFunctions.IsEvenSum(array);
            int suitable_elements_cnt = LabFunctions.CountOddOrEven(array, isEvenSum);

            if (isEvenSum)
            {
                MessageBox.Show("Найдено " + suitable_elements_cnt + " нечетных (по значению) элементов");
            }
            else
            {
                MessageBox.Show("Найдено " + suitable_elements_cnt + " четных (по значению) элементов");
            }

            array2 = LabFunctions.ConditionalArrayForLab5(array, suitable_elements_cnt);

            dataGridView2.Rows.Clear();
            LabFunctions.tabulateArrayToDataGridView(array2, dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void createExcelFile_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook WB = excel.Workbooks.Add();
            Excel.Worksheet ws = WB.Worksheets[1];
            ws.Name = "Исходная матрица";

            // Вывод исходной матрицы
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    ws.Cells[i + 1, j + 1] = array[i, j];
                }
            }

            Excel.Worksheet ws2 = WB.Worksheets.Add();
            ws2.Name = "Конечный массив";

            // Вывод конечного массива
            for (int i = 0; i < array2.Length; i++)
            {
                ws2.Cells[i + 1, 1] = array2[i];
            }

            excel.Visible = true;
            excel.UserControl = true;
        }


        private void createWordFile_Click(object sender, EventArgs e)
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Range range = doc.Range();

            range.Text = "Исходная матрица:\n";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    range.Text += array[i, j].ToString() + "\t";
                }
                range.Text += "\n";
            }

            range.Text += "\nКонечный массив:\n";
            for (int i = 0; i < array2.Length; i++)
            {
                range.Text += "[" + i + "] " + array2[i].ToString() + "\n";
            }

            word.Visible = true;
        }


        private void createTextFile_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = File.CreateText("Массивы.txt");
            streamWriter.WriteLine("Исходная матрица:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    streamWriter.Write(array[i, j].ToString() + "\t");
                }
                streamWriter.WriteLine();
            }
            streamWriter.WriteLine("Конечный массив:");
            for (int i = 0; i < array2.Length; i++)
            {
                streamWriter.WriteLine(array2[i].ToString());
            }

            streamWriter.Close();
            Process.Start("Массивы.txt");
        }




    }



}
