using Lab3Sem2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_sem2
{
    public partial class Lab4TaskForm : Form
    {
        public Lab4TaskForm()
        {
            InitializeComponent();
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Lab4AnswerFormType1 newForm = new Lab4AnswerFormType1();
            newForm.Show();
            this.Hide();
        }
    }
}
