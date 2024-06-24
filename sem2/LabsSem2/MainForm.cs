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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            TQuestionList.InitDefaultQuetion();
            InitializeComponent();
        }
        private void button_Lab3TaskForm(object sender, EventArgs e)
        {
            Lab3TaskForm newForm = new Lab3TaskForm();
            newForm.Show();
            this.Hide();
        }

        private void button_Lab4TaskForm(object sender, EventArgs e)
        {
            Lab4TaskForm newForm = new Lab4TaskForm();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab5TaskForm FormTest = new Lab5TaskForm();
            FormTest.Show();
            this.Hide();
        }

    }
}
