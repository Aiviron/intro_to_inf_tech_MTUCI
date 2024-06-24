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
    public partial class Lab4AnswerFormType4 : Form
    {
        public Lab4AnswerFormType4()
        {
            InitializeComponent();
            listBox1.Items.Add("a) недооценка сложности и стоимости проекта, нехватка квалифицированного персонала;");
            listBox1.Items.Add("b) несоответствие программного обеспечения требованиям предприятия, недостаточная проработка бизнес-процессов;");
            listBox1.Items.Add("c) отсутствие поддержки со стороны топ-менеджеров, сопротивление сотрудников изменениям;");
            listBox1.Items.Add("d) все перечисленные риски");
        }

        private void skip_question_button_Click(object sender, EventArgs e)
        {
            DataForLab4.result[2] = "Вопрос был пропущен";
            Lab4AnswerFormType5 newForm = new Lab4AnswerFormType5();
            newForm.Show();
            this.Hide();
        }


        private void answerButton_Click(object sender, EventArgs e)
        {
            string selectedAnswer = listBox1.SelectedItem?.ToString();

            if (selectedAnswer == "d) все перечисленные риски")
            {
                MessageBox.Show("Верно!");
                DataForLab4.correct_answers_cnt++;
                DataForLab4.result[2] = "Верно";
            }
            else
            {
                MessageBox.Show("Неверно!");
                DataForLab4.result[2] = "Неверно";
            }


            Lab4AnswerFormType5 newForm = new Lab4AnswerFormType5();
            newForm.Show();
            this.Hide();
        }


    }
}