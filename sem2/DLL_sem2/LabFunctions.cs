using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_sem2
{
    public class LabFunctions
    {
        //функции для 3-ей Лабораторной работы
        public static void generateArray(int[] array, int length, int start, int end)
        {
            Random element_generator = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = element_generator.Next(start, end);
            }
        }


        public static void tabulateArrayToDataGridView(int[] array, DataGridView dataGridView)
        {
            int length = array.Length;
            dataGridView.ColumnCount = length;
            dataGridView.RowCount = 2;
            for (int i = 0; i < length; i++)
            {
                dataGridView.Rows[0].Cells[i].Value = "[" + i + "]";
                dataGridView.Rows[1].Cells[i].Value = array[i];
            }
        }


        public static int сonditionalСounter(int[] array) //Счетчик значений, которые удовлетворяют условию задачи
        {
            int сonditional_cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 200 && array[i] % 5 == 0)
                {
                    сonditional_cnt++;
                }
            }

            return сonditional_cnt;
        }


        public static int[] сonditionalArray(int[] array, int сonditional_count)
        {
            int size_res_array = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > сonditional_count)
                    size_res_array++;
            }
            int[] result_array = new int[size_res_array];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > сonditional_count)
                {
                    result_array[index] = array[i];
                    index++;
                }
            }
            return result_array;
        }


        //Далее функции для 5-ой Лабораторной работы

        public static bool IsEvenSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum % 2 == 0;
        }

        public static int CountOddOrEven(int[,] array, bool isEven)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((array[i, j] % 2 == 1 && isEven) || (array[i, j] % 2 == 0 && !isEven))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int[] ConditionalArrayForLab5(int[,] array, int conditionCount)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < conditionCount)
                    {
                        count++;
                    }
                }
            }

            int[] resultArray = new int[count];
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < conditionCount)
                    {
                        resultArray[index] = array[i, j];
                        index++;
                    }
                }
            }

            return resultArray;
        }

        public static void generateArray2D(int[,] array, int rows, int cols, int start, int end)
        {
            Random element_generator = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = element_generator.Next(start, end);
                }
            }
        }

        public static void tabulateArrayToDataGridView2D(int[,] array, DataGridView dataGridView)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            dataGridView.ColumnCount = cols;
            dataGridView.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }





    }

}



