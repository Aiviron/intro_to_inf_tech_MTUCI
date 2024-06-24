using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using DataNamespace;
using System.Collections.Specialized;

namespace Lab3_sem2
{
    public partial class Lab4AnswerFormType2 : Form
    {
        public Lab4AnswerFormType2()
        {
            InitializeComponent();
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (answer_radioButton1.Checked && !answer_radioButton2.Checked && !answer_radioButton3.Checked)
            {
                MessageBox.Show("Верно!");
                DataForLab4.result[1] = "Верно";
                DataForLab4.correct_answers_cnt++;

                Lab4AnswerFormType4 newForm = new Lab4AnswerFormType4();
                newForm.Show();
                this.Hide();
            }
            else if (!answer_radioButton1.Checked && answer_radioButton2.Checked && !answer_radioButton3.Checked)
            {
                MessageBox.Show("Неверно!");
                DataForLab4.result[1] = "Неверно";

                Lab4AnswerFormType4 newForm = new Lab4AnswerFormType4();
                newForm.Show();
                this.Hide();
            }
            else if (!answer_radioButton1.Checked && !answer_radioButton2.Checked && answer_radioButton3.Checked)
            {
                MessageBox.Show("Неверно!");
                DataForLab4.result[1] = "Неверно";

                Lab4AnswerFormType4 newForm = new Lab4AnswerFormType4();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }


        }

        private void skip_question_button_Click(object sender, EventArgs e)
        {
            DataForLab4.result[1] = "Вопрос был пропущен";
            Lab4AnswerFormType4 newForm = new Lab4AnswerFormType4();
            newForm.Show();
            this.Hide();
        }
    }
}