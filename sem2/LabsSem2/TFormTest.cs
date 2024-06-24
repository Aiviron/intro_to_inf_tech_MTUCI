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

    public partial class TFormTest : Form
    {
        public void LoadQuetion(int _quetion_num)
        {
            GB_rbAnswers.Controls.Clear();
            RTB_Question.Text = TQuestionList.Questions[_quetion_num].Text;
            int CurrType = TQuestionList.Questions[_quetion_num].Type;
            if (CurrType == (int)AnswersTypes.FreeText)
            {
                TB_TextAswer.Visible = true;  
            }
            else
            {
                TB_TextAswer.Visible = false;
                int Curr_Ans_Cnt = TQuestionList.Questions[_quetion_num].SuggestAnswers.Length;
                for (int i = 0; i < Curr_Ans_Cnt; i++)
                {
                    RadioButton _rb = new RadioButton();
                    _rb.Click += BT_Radio_Click;
                    _rb.Location = new Point(20, 40 + 30 * i);
                    _rb.Name = i.ToString();
                    GB_rbAnswers.Controls.Add(_rb);
                    RadioButton RB = (RadioButton)GB_rbAnswers.Controls[i];
                    RB.Show();
                    RB.Text = TQuestionList.Questions[_quetion_num].SuggestAnswers[i];
                }
            }
        }
        public TFormTest()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void BT_start_click(object sender, EventArgs e)
        {
            TQuestionList.GoFirstQuenstion();
            LoadQuetion(TQuestionList.CurrentQuenstionNum);
        }

        private void BT_Radio_Click(object sender, EventArgs e)
        {
            int qnum = TQuestionList.CurrentQuenstionNum;
            RadioButton _rb = (RadioButton)sender;
            TQuestionList.Questions[qnum].UserAnswerText = _rb.Text;
            TQuestionList.Questions[qnum].UserAnswerNumber = Int32.Parse(_rb.Name);
            MessageBox.Show(TQuestionList.Questions[qnum].UserAnswerNumber.ToString());


        }
        private void BT_Next_Click(object sender, EventArgs e)
        {
            int qnum = TQuestionList.CurrentQuenstionNum;
            if (TQuestionList.Questions[qnum].Type == (int)AnswersTypes.Predefined)
            {
                int ti = TQuestionList.Questions[qnum].UserAnswerNumber = GB_rbAnswers.TabIndex;
                MessageBox.Show(ti.ToString());
            }
            
            TQuestionList.GoNextQuenstion();
            LoadQuetion(TQuestionList.CurrentQuenstionNum);
        }
    }
}
