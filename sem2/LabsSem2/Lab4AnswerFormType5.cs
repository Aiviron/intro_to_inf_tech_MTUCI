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
    public partial class Lab4AnswerFormType5 : Form
    {
        private int correct_answers_count = 0;

        public Lab4AnswerFormType5()
        {
            InitializeComponent();
            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            // (ListBox)
            listBox1.Items.Add("б) Ведение бухгалтерского учета");
            listBox1.Items.Add("г) Анализ рынка и конкурентов");
            listBox1.Items.Add("в) Управление логистикой и складскими запасами");

            // (TextBox)
            label3.Text = "Что обрабатывает АСУП для принятия управленческих решений?";

            // (RadioButton)
            answer_radioButton1.Text = "Аналитическая система учета персонала";
            answer_radioButton2.Text = "Автоматизированная система управления производством ";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            correct_answers_count = 0;

            if (listBox1.SelectedItem?.ToString() == "в) Управление логистикой и складскими запасами")
                correct_answers_count++;

            if (textBox1.Text.ToLower().Trim() == "данные")
                correct_answers_count++;

            if (!answer_radioButton1.Checked && answer_radioButton2.Checked)
                correct_answers_count++;

            if (correct_answers_count == 3)
            {
                MessageBox.Show("Все верно!");
                DataForLab4.result[3] = "Верно";
                DataForLab4.correct_answers_cnt++;
                Lab4AnswerFormType7_ newform = new Lab4AnswerFormType7_();
                newform.Show();
                this.Hide();
            }

            else
                MessageBox.Show($" Вы дали {correct_answers_count} правильных ответов");
                DataForLab4.result[3] = "Неверно";
                Lab4AnswerFormType7_ newForm = new Lab4AnswerFormType7_();
                newForm.Show();
                this.Hide();
        }


        private void skip_question_button_Click(object sender, EventArgs e)
        {
            DataForLab4.result[3] = "Вопрос был пропущен";
            Lab4AnswerFormType7_ newForm = new Lab4AnswerFormType7_();
            newForm.Show();
            this.Hide();
        }
    }
}
