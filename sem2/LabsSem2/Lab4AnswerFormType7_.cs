using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataNamespace;

namespace Lab3_sem2
{
    public partial class Lab4AnswerFormType7_ : Form
    {
        public Lab4AnswerFormType7_()
        {
            InitializeComponent();
            comboBox1.Items.Add("Простота установки и настройки, низкая стоимость");
            comboBox1.Items.Add("Возможность работы в автономном режиме");
            comboBox1.Items.Add("Надежность, гибкость и масштабируемость");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Предполагаем, что правильный ответ - третий вариант
            int correctAnswerIndex = 2;

            if (comboBox1.SelectedIndex == correctAnswerIndex)
            {
                MessageBox.Show("Правильный ответ!");
                DataForLab4.result[4] = "Верно";
                DataForLab4.correct_answers_cnt++;
                Lab4ResultForm newform = new Lab4ResultForm();
                newform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Неправильный ответ.");
                DataForLab4.result[4] = "Неверно";
                Lab4ResultForm newform = new Lab4ResultForm();
                newform.Show();
                this.Hide();
            }
        }

        private void skip_question_button_Click(object sender, EventArgs e)
        {
            DataForLab4.result[4] = "Вопрос был пропущен";
            Lab4ResultForm newform = new Lab4ResultForm();
            newform.Show();
            this.Hide();
        }
    }
}
