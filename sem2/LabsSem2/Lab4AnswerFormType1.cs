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
    public partial class Lab4AnswerFormType1 : Form
    {
        public Lab4AnswerFormType1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            
            if (answer_textBox1.Text == " " || answer_textBox1.Text == "")
            {
                MessageBox.Show("Вы не дали ответ на вопрос");
            }
            else if (answer_textBox1.Text.ToUpper() == "ЧПУ")
            {
                DataForLab4.correct_answers_cnt++;
                DataForLab4.result[0] = "Верно";
                MessageBox.Show("Верно!");

                Lab4AnswerFormType2 newForm = new Lab4AnswerFormType2();
                newForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Неверно!");
                DataForLab4.result[0] = "Неверно";

                Lab4AnswerFormType2 newForm = new Lab4AnswerFormType2();
                newForm.Show();
                this.Hide();
            }


        }

        private void skip_question_button_Click(object sender, EventArgs e)
        {

            Lab4AnswerFormType2 newForm = new Lab4AnswerFormType2();
            newForm.Show();
            this.Hide();
            DataForLab4.result[0] = "Вопрос был пропущен";

        }
    }
}
